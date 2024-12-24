using System.Data;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace Filler
{
    public partial class infill : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        private System.Windows.Forms.Timer checkTimer;
        private System.Windows.Forms.Timer checkTimer2;
        private const uint MOD_CONTROL = 0x0002;
        private const uint MOD_ALT = 0x0001;
        private const int HOTKEY_ID = 1;
        private bool isExecuting = false;
        private bool isComboBoxOpen = false;//fix for profiles combobox

        private const uint KLF_SETFORPROCESS = 0x00000100;
        private bool stopExecution = false;
 

        private void SetTabOrder()
        {
            checkBox1.TabIndex = 0;
            textBox1.TabIndex = 1;
            textBox2.TabIndex = 2;
            textBox3.TabIndex = 3;
            textBox4.TabIndex = 4;
            textBox5.TabIndex = 5;
            textBox6.TabIndex = 6;
            textBox7.TabIndex = 7;
            textBox8.TabIndex = 8;
            textBox9.TabIndex = 9;
            checkBox3.TabIndex = 10;
            checkBox4.TabIndex = 11;
            checkBox5.TabIndex = 12;
            checkBox8.TabIndex = 13;
            checkBox7.TabIndex = 14;
            checkBox6.TabIndex = 15;
            checkBox11.TabIndex = 16;
            checkBox10.TabIndex = 17;
            checkBox9.TabIndex = 18;
            checkBox12.TabIndex = 19;
            checkBox14.TabIndex = 20;
            checkBox15.TabIndex = 21;
            checkBox16.TabIndex = 22;
            checkBox17.TabIndex = 23;
            checkBox18.TabIndex = 24;
            checkBox19.TabIndex = 25;
            checkBox20.TabIndex = 26;
            checkBox21.TabIndex = 27;
            checkBox13.TabIndex = 28;
            checkBox22.TabIndex = 29;
            checkBox23.TabIndex = 30;
            checkBox24.TabIndex = 31;
            checkBox25.TabIndex = 32;
            checkBox26.TabIndex = 33;
            checkBox27.TabIndex = 34;
            checkBox28.TabIndex = 35;
            checkBox29.TabIndex = 36;
            checkBox2.TabIndex = 37;
        }



//encryption module
        public static class CryptoHelper
        {
            public static string Encrypt(string plainText, string password)
            {
                using (Aes aes = Aes.Create())
                {
                    var key = new Rfc2898DeriveBytes(password, new byte[16], 10000);
                    aes.Key = key.GetBytes(32);
                    aes.IV = key.GetBytes(16);

                    using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                    using (var ms = new MemoryStream())
                    {
                        using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                        using (var sw = new StreamWriter(cs))
                        {
                            sw.Write(plainText);
                        }
                        return Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
            public static string Decrypt(string cipherText, string password)
            {
                using (Aes aes = Aes.Create())
                {
                    var key = new Rfc2898DeriveBytes(password, new byte[16], 10000);
                    aes.Key = key.GetBytes(32);
                    aes.IV = key.GetBytes(16);

                    using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                    using (var ms = new MemoryStream(Convert.FromBase64String(cipherText)))
                    using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
                    using (var sr = new StreamReader(cs))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
        }


//timers
        private void InitializeTimer()
        {
            checkTimer = new System.Windows.Forms.Timer();
            checkTimer.Interval = 100; //ms 
            checkTimer.Tick += new EventHandler(CheckTimer_Tick);
            checkTimer.Start();
        }
        private void InitializeTimer2()
        {
            checkTimer2 = new System.Windows.Forms.Timer();
            checkTimer2.Interval = 100; //ms
            checkTimer2.Tick += new EventHandler(CheckTimer2_Tick);
            checkTimer2.Start();
        }
        private void CheckTimer_Tick(object sender, EventArgs e)//check button release
        {
            SendKeys.SendWait("");
            UpdateModifierKeysLabel();
            if (label1.Text.Contains("None"))
            {
                checkTimer.Stop();
                ExecuteTypewriter();
            }
        }
        private void CheckTimer2_Tick(object sender, EventArgs e)//autosave
        {
            UpdateModifierKeysLabel2();
            UpdateModifierKeysLabel3();

            if (!isComboBoxOpen)
            {
                string currentProfileName = Profiles.SelectedItem?.ToString();
                if (string.IsNullOrEmpty(currentProfileName)) return;
                else
                    SaveCurrentProfileData(currentProfileName);
            }
        }



//profile dictionary
        private Dictionary<string, string> profileDataDict = new Dictionary<string, string>();
        public infill()
        {
            InitializeComponent();
            InitializeTimer2();
            SetTabOrder();
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, GetKeyFromComboBox());
            button1.Visible = false;
            button2.Visible = false;
            textBox2.Multiline = false;
            textBox2.UseSystemPasswordChar = true;




            //hotkeys module
            for (int i = 0; i < 9; i++)
            {
                RegisterHotKey(this.Handle, HOTKEY_ID + i + 1, MOD_CONTROL, (uint)Keys.D1 + (uint)i);
            }
        }



        private void Profiles_DropDown(object sender, EventArgs e)
        {
            isComboBoxOpen = true;
        }

        private void Profiles_DropDownClosed(object sender, EventArgs e)
        {
            isComboBoxOpen = false;
        }




        private uint GetKeyFromComboBox()
        {
            var selectedKeyString = Hotkeys.SelectedItem?.ToString();
            return !string.IsNullOrEmpty(selectedKeyString) ? (uint)selectedKeyString.Last() : (uint)Keys.V;
        }

        private void Hotkeys_SelectedIndexChanged(object sender, EventArgs e)
        {
            UnregisterHotKey(this.Handle, HOTKEY_ID);
            RegisterHotKey(this.Handle, HOTKEY_ID, MOD_CONTROL | MOD_ALT, GetKeyFromComboBox());
            this.Text = $"infill | Ctrl+Alt+{Hotkeys.SelectedItem?.ToString().Last()}";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (isExecuting) stopExecution = true;
            base.OnFormClosing(e);
            UnregisterHotKey(this.Handle, HOTKEY_ID);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int hotkeyId = m.WParam.ToInt32();
                if (hotkeyId >= HOTKEY_ID + 1 && hotkeyId <= HOTKEY_ID + 9)
                {
                    int checkBoxIndex = hotkeyId - HOTKEY_ID - 1;
                    var checkBoxes = new[] { checkBox3, checkBox4, checkBox5, checkBox8, checkBox7, checkBox6, checkBox11, checkBox10, checkBox9 };
                    checkBoxes[checkBoxIndex].Checked = !checkBoxes[checkBoxIndex].Checked;
                }
                else if (hotkeyId == HOTKEY_ID)
                {
                    if (isExecuting)
                    {
                        stopExecution = true;
                    }
                    else
                    {
                        isExecuting = true;
                        InitializeTimer();
                    }
                }
            }
            base.WndProc(ref m);
        }



//typewriter
        private async void ExecuteTypewriter()
        {
            try
            {
                var tasks = new[]
                {
            ProcessFieldAsync(checkBox3, textBox1, checkBox13, checkBox13.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox4, textBox2, checkBox22, checkBox22.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox5, textBox3, checkBox23, checkBox23.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox8, textBox4, checkBox24, checkBox24.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox7, textBox5, checkBox25, checkBox25.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox6, textBox6, checkBox26, checkBox26.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox11, textBox7, checkBox27, checkBox27.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox10, textBox8, checkBox28, checkBox28.Checked ? "{Tab}" : "{Enter}"),
            ProcessFieldAsync(checkBox9, textBox9, checkBox29, checkBox29.Checked ? "{Tab}" : "{Enter}")
        };

                foreach (var task in tasks)
                {
                    if (stopExecution) break;
                    await task;
                }
            }
            finally
            {
                button1.Visible = false;
                isExecuting = false;
                stopExecution = false;
            }
        }



//keyboard simulator
        private async Task ProcessFieldAsync(CheckBox checkBox, TextBox textBox, CheckBox radioButton, string keyToSend)
        {
            if (!stopExecution)//check stop-button
            {
                if (checkBox.Checked)
                {
                    button1.Visible = true;

                    if (!stopExecution)//check stop-button
                    {
                        isExecuting = true;
                        foreach (char c in textBox.Text.Where(c => c != '\n'))
                        {
                            if (!stopExecution)//check stop-button
                            {

                                SendKeys.SendWait(Regex.Replace(c.ToString(), "[+^%~(){}]", "{$0}"));
                                if (checkBox1.Checked) Thread.Sleep(100);//slow mode
                            }
                            else
                            {
                                button1.Visible = false;
                            }
                        }
                        if (!stopExecution) { SendKeys.SendWait(keyToSend); }//tab or enter

                    }
                    else
                    {
                        isExecuting = false;
                        button1.Visible = false;
                    }
                }
            }
            else
            {
                isExecuting = false;
                button1.Visible = false;
            }
        }

        private void TogglePasswordVisibility(CheckBox checkBox, TextBox textBox)
        {
            textBox.Multiline = checkBox.Checked;
            textBox.UseSystemPasswordChar = !checkBox.Checked;
        }
        private void checkBox14_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox14, textBox2);
        private void checkBox12_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox12, textBox1);
        private void checkBox15_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox15, textBox3);
        private void checkBox16_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox16, textBox4);
        private void checkBox17_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox17, textBox5);
        private void checkBox18_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox18, textBox6);
        private void checkBox19_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox19, textBox7);
        private void checkBox20_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox20, textBox8);
        private void checkBox21_CheckedChanged(object sender, EventArgs e) => TogglePasswordVisibility(checkBox21, textBox9);
        private void checkBox2_CheckedChanged(object sender, EventArgs e) => this.TopMost = checkBox2.Checked; //topmost



//event on text box enter
        private void TextBox_Enter(object sender, EventArgs e, string defaultText, CheckBox associatedCheckBox)
        {
            if (sender != previousFocusedControl) { previousFocusedControl = sender as Control; }
            button2.Visible = true;
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text == defaultText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
                if (associatedCheckBox != null) associatedCheckBox.Checked = true;
            }
            string currentProfileName = Profiles.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(currentProfileName)) return;
            else
                SaveCurrentProfileData(currentProfileName);
        }



//event on leaving textbox
        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (!button2.Focused)
                button2.Visible = false;
            string currentProfileName = Profiles.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(currentProfileName)) return;
            else
                SaveCurrentProfileData(currentProfileName);
        }
        private void textBox1_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "admin", checkBox3);
        private void textBox1_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox2_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "P@ssw0rd", checkBox4);
        private void textBox2_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox3_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox3_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox4_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox4_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox5_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox5_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox6_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox6_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox7_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox7_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox8_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox8_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);
        private void textBox9_Enter(object sender, EventArgs e) => TextBox_Enter(sender, e, "", null);
        private void textBox9_Leave(object sender, EventArgs e) => TextBox_Leave(sender, e);



//save method
        private void SaveCurrentProfileData(string profileName)
        {
            var textBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            var checkBoxes = new[] { checkBox3, checkBox4, checkBox5, checkBox8, checkBox7, checkBox6, checkBox11, checkBox10, checkBox9 };
            var radioButtons = new[] { checkBox13, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29 };
            var checkEyes = new[] { checkBox12, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21 };
            var colors = new[] { Color.Bisque, Color.Honeydew, Color.Lavender, Color.White };

            string profileData = $"0:{profileName}";
            for (int i = 0; i < textBoxes.Length; i++)
            {
                int checkBoxState = checkBoxes[i].Checked ? 1 : 0;
                int radioButtonState = radioButtons[i].Checked ? 1 : 0;
                int checkEyesState = checkEyes[i].Checked ? 1 : 0;
                int colorIndex = Array.IndexOf(colors, textBoxes[i].BackColor); //color index
                if (colorIndex == -1) colorIndex = 3; // fix for undefined color
                string text = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(textBoxes[i].Text));//convert to Base64

                profileData += $";{i + 1}{checkBoxState}{radioButtonState}{checkEyesState}{colorIndex}:{text}";
            }
            profileDataDict[profileName] = profileData;
        }




//load file
        private void LoadProfileData(string profileName)
        {
            if (!profileDataDict.TryGetValue(profileName, out string profileData)) return;
            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;
            var textBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            var checkBoxes = new[] { checkBox3, checkBox4, checkBox5, checkBox8, checkBox7, checkBox6, checkBox11, checkBox10, checkBox9 };
            var radioButtons = new[] { checkBox13, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29 };
            var checkEyes = new[] { checkBox12, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21 };
            var colors = new[] { Color.Bisque, Color.Honeydew, Color.Lavender, Color.White };

            foreach (var textBox in textBoxes) textBox.Text = "";

            foreach (string entry in profileData.Split(';'))
            {
                var parts = entry.Split(new[] { ':' }, 2);
                if (parts.Length == 2 && parts[0].Length == 5 && int.TryParse(parts[0][0].ToString(), out int textBoxIndex) && textBoxIndex >= 1 && textBoxIndex <= 9)
                {
                    //get Base64 text
                    string textValue = System.Text.Encoding.UTF8.GetString(Convert.FromBase64String(parts[1]));
                    textBoxes[textBoxIndex - 1].Text = textValue;

                    checkBoxes[textBoxIndex - 1].Checked = int.Parse(parts[0][1].ToString()) == 1;
                    radioButtons[textBoxIndex - 1].Checked = int.Parse(parts[0][2].ToString()) == 1;
                    checkEyes[textBoxIndex - 1].Checked = int.Parse(parts[0][3].ToString()) == 1;
                    int colorIndex = int.Parse(parts[0][4].ToString());
                    textBoxes[textBoxIndex - 1].BackColor = colors[colorIndex];
                }
            }
        }






//reset fields
        private void ClearProfileFields()
        {
            var textBoxes = new[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9 };
            var checkBoxes = new[] { checkBox3, checkBox4, checkBox5, checkBox8, checkBox7, checkBox6, checkBox11, checkBox10, checkBox9 };
            var radioButtons = new[] { checkBox13, checkBox22, checkBox23, checkBox24, checkBox25, checkBox26, checkBox27, checkBox28, checkBox29 };
            var checkEyes = new[] { checkBox12, checkBox14, checkBox15, checkBox16, checkBox17, checkBox18, checkBox19, checkBox20, checkBox21 };

            foreach (var textBox in textBoxes)
            {
                textBox.Text = "";
                textBox.BackColor = Color.White;
            }
            foreach (var checkBox in checkBoxes) checkBox.Checked = false;
            foreach (var radioButton in radioButtons) radioButton.Checked = false;
            foreach (var checkEye in checkEyes) checkEye.Checked = true;
        }



//create new profile
        private void createProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string profileName = Profiles.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(profileName))
            {
                SaveCurrentProfileData(profileName);
            }

            string newProfileName = Prompt.ShowDialog("\nEnter profile name:", "New profile");
            if (string.IsNullOrEmpty(newProfileName) || newProfileName == "CANCEL") return;

            if (profileDataDict.ContainsKey(newProfileName.ToLower()))
            {
                MessageBox.Show("This profile name is already taken. Please, use different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Profiles.Items.Add(newProfileName);
            Profiles.SelectedItem = newProfileName;
            if (!string.IsNullOrEmpty(profileName))
            {
                ClearProfileFields(); //dont reset if profile is first
            }


            textBox1.ForeColor = Color.Black;
            textBox2.ForeColor = Color.Black;

            SaveCurrentProfileData(newProfileName);
        }




//profile edit
        private void deleteProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string currentProfileName = Profiles.SelectedItem?.ToString();
            if (string.IsNullOrEmpty(currentProfileName)) { createProfileToolStripMenuItem_Click(sender, e); return; }

            string newProfileName = Prompt.ShowDialog("Set new name:\n(leave empty to delete profile)", "Edit profile", currentProfileName);
            if (string.IsNullOrEmpty(newProfileName))
            {
                var result = MessageBox.Show("Do you really wish to delete profile?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    profileDataDict.Remove(currentProfileName);
                    Profiles.Items.Remove(currentProfileName);
                    if (Profiles.Items.Count > 0)
                    {
                        Profiles.SelectedIndex = Profiles.Items.Count - 1;
                    }
                    else
                    {
                        ClearProfileFields();
                        Profiles.Text = "Profile";
                    }
                }
                return;
            }
            else if (newProfileName == "CANCEL") return;
            else 
            {
                profileDataDict.Remove(currentProfileName);
                Profiles.Items.Remove(currentProfileName);
            }
            if (profileDataDict.ContainsKey(newProfileName.ToLower()))
            {
                MessageBox.Show("This profile name is already taken. Please, use different name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Profiles.Items.Add(newProfileName);
            Profiles.SelectedItem = newProfileName;
            SaveCurrentProfileData(newProfileName);
        }



//prompt window module
        public static class Prompt
        {
            public static string ShowDialog(string text, string caption, string defaultValue = "", bool useSystemPasswordChar = false)
            {
                Form prompt = new Form()
                {
                    Width = 322,
                    Height = 182,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    Text = caption,
                    StartPosition = FormStartPosition.CenterScreen,
                    TopMost = true
                };

                Label textLabel = new Label()
                {
                    Left = 8,
                    Top = 15,
                    Text = text,
                    AutoSize = true
                };

                TextBox textBox = new TextBox()
                {
                    Left = 10,
                    Top = 57,
                    Width = 286,
                    UseSystemPasswordChar = useSystemPasswordChar
                };

                Button confirmation = new Button()
                {
                    Text = "OK",
                    Left = 103,
                    Width = 100,
                    Top = 100,
                    DialogResult = DialogResult.OK
                };
                confirmation.Click += (sender, e) =>
                {
                    prompt.Close();
                };

                prompt.Controls.Add(textBox);
                prompt.Controls.Add(confirmation);
                prompt.Controls.Add(textLabel);
                prompt.AcceptButton = confirmation;

                return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "CANCEL";
            }
        }



//profile click event
        private void Profiles_Click(object sender, EventArgs e)
        {
            if (!isComboBoxOpen)
            {
                string profileName = Profiles.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(profileName))
                {
                    SaveCurrentProfileData(profileName);
                }
            }
        }



//select other profile event
        private void Profiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isComboBoxOpen)
            {
                string profileName = Profiles.SelectedItem?.ToString();
                if (!string.IsNullOrEmpty(profileName))
                {
                    LoadProfileData(profileName);
                }
            }
        }



//hotkeys monitoring
        private void UpdateModifierKeysLabel()
        {
            Keys modifiers = Control.ModifierKeys;
            label1.Text = $"{modifiers}";
        }



//monitoring profiles

        private void UpdateModifierKeysLabel2()
        {
            string profileName = Profiles.SelectedItem?.ToString();
            label2.Text = $"{profileName}";
        }



//monitoring combobox

        private void UpdateModifierKeysLabel3()
        {
            label3.Text = $"{isComboBoxOpen}";
        }


//save as...
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Profiles.Items.Count == 0)
            {
                MessageBox.Show("Profiles absent. Create at least one profile in order to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string profileName = Profiles.SelectedItem?.ToString();
            if (!string.IsNullOrEmpty(profileName)) SaveCurrentProfileData(profileName);

            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Filter = "Infill saves (*.fil)|*.fil|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "db.fil"
            };

            if (saveFileDialog1.ShowDialog() != DialogResult.OK) return;

            string password1 = Prompt.ShowDialog("Set encryption key \n(or leave empty to disable encryption):", "Password", "", true);
            if (password1 == "CANCEL") return; //break if dialog window closed

            if (!string.IsNullOrEmpty(password1))
            {
                string password2 = Prompt.ShowDialog("Repeat password:", "Password confirmation", "", true);
                if (password2 == "CANCEL" || password1 != password2)
                {
                    MessageBox.Show("Password does not match or cancelled by user. Try agiain.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            StringBuilder sb = new StringBuilder();
            foreach (var kvp in profileDataDict) sb.AppendLine($"{kvp.Key}: {kvp.Value}");
            string dataToSave = sb.ToString();

            if (!string.IsNullOrEmpty(password1))
            {
                dataToSave = CryptoHelper.Encrypt(dataToSave, password1);
            }

            using (var file = new StreamWriter(saveFileDialog1.FileName))
            {
                file.Write(dataToSave);
            }

            MessageBox.Show("File saved successfuly.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




//load module
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "Infill saves (*.fil)|*.fil|All files (*.*)|*.*",
                FilterIndex = 1,
                RestoreDirectory = true,
                FileName = "db.fil"
            };

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            Profiles.Items.Clear();
            profileDataDict.Clear();

            string encryptedData;
            using (StreamReader file = new StreamReader(openFileDialog1.FileName))
            {
                encryptedData = file.ReadToEnd();
            }

            string password = Prompt.ShowDialog("Enter password \n(leave empty if the file is not encrypted):", "Password", "", true);
            if (password == "CANCEL") return; //break if prompt closed

            string decryptedData = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(password))
                {
                    decryptedData = encryptedData; //no encryption
                }
                else
                {
                    decryptedData = CryptoHelper.Decrypt(encryptedData, password);
                }

                using (StringReader reader = new StringReader(decryptedData))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(new[] { ": " }, 2, StringSplitOptions.None);
                        if (parts.Length == 2)
                        {
                            profileDataDict[parts[0]] = parts[1];
                        }
                    }
                }

                Profiles.Items.Clear();
                foreach (var key in profileDataDict.Keys) Profiles.Items.Add(key);

                if (Profiles.Items.Count > 0)
                {
                    Profiles.SelectedIndex = 0;
                    LoadProfileData(Profiles.SelectedItem.ToString());
                }
            }
            catch (CryptographicException)
            {
                MessageBox.Show("Incorrect password or the file is corrupt.", "Decryption error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException)
            {
                MessageBox.Show("Data structure error. Probably data is not encrypted.", "Data structure error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




//finishing button
        private void TABorENTER(CheckBox checkBox, CheckBox relatedCheckBox)
        {
            if (!checkBox.Checked)
            {
                relatedCheckBox.ForeColor = Color.White;
            }
            else
            {
                if (relatedCheckBox.Checked)
                {
                    relatedCheckBox.Text = "↹ TAB";
                    relatedCheckBox.ForeColor = Color.DarkBlue;
                }
                else
                {
                    relatedCheckBox.Text = "↵ Enter";
                    relatedCheckBox.ForeColor = Color.DarkRed;
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox3, checkBox13);
        private void checkBox3_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox3, checkBox13);
        private void checkBox4_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox4, checkBox22);
        private void checkBox22_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox4, checkBox22);
        private void checkBox5_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox5, checkBox23);
        private void checkBox23_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox5, checkBox23);
        private void checkBox8_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox8, checkBox24);
        private void checkBox24_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox8, checkBox24);
        private void checkBox7_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox7, checkBox25);
        private void checkBox25_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox7, checkBox25);
        private void checkBox6_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox6, checkBox26);
        private void checkBox26_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox6, checkBox26);
        private void checkBox11_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox11, checkBox27);
        private void checkBox27_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox11, checkBox27);
        private void checkBox10_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox10, checkBox28);
        private void checkBox28_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox10, checkBox28);
        private void checkBox9_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox9, checkBox29);
        private void checkBox29_CheckedChanged(object sender, EventArgs e) => TABorENTER(checkBox9, checkBox29);



//About
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"• Try hotkeys CTRL+[1-9] to enable or disable fields\n\n• Output characters do depend on set keyboard layout - mind that when working in remote console\n__________________________________________________________\n\nReleased in 2024 as freeware.\n\nDev's blog: t.me/sysarch01\n__________________________________________________________\n\nChecksum and source code are available at\n\n• github.com/plainwave/infill\n\n", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



//STOP button
        private void button1_Click_1(object sender, EventArgs e)
        {
            stopExecution = true;
        }



//color button
        private int colorIndex = 0;
        private readonly Color[] colors = { Color.Bisque, Color.Honeydew, Color.Lavender, Color.White };
        private Control previousFocusedControl = null;
        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = colors[colorIndex];
            if (previousFocusedControl != null) { previousFocusedControl.BackColor = colors[colorIndex]; }
            colorIndex = (colorIndex + 1) % colors.Length;
        }
        private void button2_Leave(object sender, EventArgs e)
        {
            button2.Visible = false;
        }



    }
}