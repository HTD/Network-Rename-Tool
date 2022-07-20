using System.Windows.Forms;
using Microsoft.Win32;

namespace NetworkRenameTool {

    /// <summary>
    /// The main program window.
    /// </summary>
    public partial class MainForm : Form {

        /// <summary>
        /// Creates main window.
        /// </summary>
        public MainForm() {
            InitializeComponent();
            FeedProfiles();
        }

        /// <summary>
        /// Gets Windows network profiles from the Registry and feeds them into the grid.
        /// </summary>
        private void FeedProfiles() {
            NetworksGrid.Rows.Clear();
            using (var profilesKey = Registry.LocalMachine.OpenSubKey(ProfilesPath)) {
                foreach (var subkeyName in profilesKey.GetSubKeyNames()) {
                    using (var subkey = profilesKey.OpenSubKey(subkeyName)) {
                        NetworksGrid.Rows.Add(new[] { subkeyName, subkey.GetValue(ProfileNameKey), subkey.GetValue(DescriptionKey), System.Convert.ToInt32((subkey.GetValue(CategoryKey))) });
                    }
                }
            }
        }

        /// <summary>
        /// Handles grid cell modification event.
        /// </summary>
        /// <param name="sender"><see cref="DataGridView"/>.</param>
        /// <param name="e">Event data.</param>
        private void NetworksGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e) {
            if (e.ColumnIndex >= 0 && e.RowIndex >= 0) {
                var grid = sender as DataGridView;
                var row = grid.Rows[e.RowIndex];
                var subkeyName = (string)row.Cells[0].Value;
                var targetKeyName = $"{ProfilesPath}\\{subkeyName}";
                string value;
                int valueInt32;
                bool int32ParseSuccess;
                switch (e.ColumnIndex) {
                    case 1:
                        value = (string)row.Cells[1].Value;
                        using (var subkey = Registry.LocalMachine.OpenSubKey(targetKeyName, true)) subkey.SetValue(ProfileNameKey, value);
                        break;
                    case 2:
                        value = (string)row.Cells[2].Value;
                        using (var subkey = Registry.LocalMachine.OpenSubKey(targetKeyName, true)) subkey.SetValue(DescriptionKey, value);
                        break;
                    case 3:
                        value = (string)row.Cells[3].Value;
                        int32ParseSuccess = System.Int32.TryParse(value, out valueInt32);
                        if (!int32ParseSuccess)
                        {
                            valueInt32 = 0;
                        }
                        using (var subkey = Registry.LocalMachine.OpenSubKey(targetKeyName, true)) subkey.SetValue(CategoryKey, valueInt32);
                        row.Cells[3].Value = valueInt32.ToString();
                        break;
                }
            }
        }

        /// <summary>
        /// Handles grid row delete event.
        /// </summary>
        /// <param name="sender"><see cref="DataGridView"/>.</param>
        /// <param name="e">Event data.</param>
        private void NetworksGrid_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e) {
            var subkeyName = (string)e.Row.Cells[0].Value;
            using (var profilesKey = Registry.LocalMachine.OpenSubKey(ProfilesPath, true)) profilesKey.DeleteSubKey(subkeyName);
        }

        /// <summary>
        /// Handles grid key down event.
        /// </summary>
        /// <param name="sender"><see cref="DataGridView"/>.</param>
        /// <param name="e">Event data.</param>
        private void NetworksGrid_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyData == (Keys.Control | Keys.R)) FeedProfiles();
        }

        #region Constants

        private const string ProfilesPath = @"SOFTWARE\Microsoft\Windows NT\CurrentVersion\NetworkList\Profiles";
        private const string ProfileNameKey = "ProfileName";
        private const string DescriptionKey = "Description";
        private const string CategoryKey = "Category";

        #endregion

    }

}