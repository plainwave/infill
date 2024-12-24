using System.Windows.Forms;

namespace Filler
{
    partial class infill
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(infill));
            checkBox1 = new CheckBox();
            textBox1 = new TextBox();
            checkBox2 = new CheckBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox6 = new CheckBox();
            textBox6 = new TextBox();
            checkBox7 = new CheckBox();
            textBox5 = new TextBox();
            checkBox8 = new CheckBox();
            textBox4 = new TextBox();
            checkBox9 = new CheckBox();
            textBox9 = new TextBox();
            checkBox10 = new CheckBox();
            textBox8 = new TextBox();
            checkBox11 = new CheckBox();
            textBox7 = new TextBox();
            checkBox12 = new CheckBox();
            menuStrip1 = new MenuStrip();
            File = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripSeparator();
            createProfileToolStripMenuItem = new ToolStripMenuItem();
            deleteProfileToolStripMenuItem = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripSeparator();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            Profiles = new ToolStripComboBox();
            Hotkeys = new ToolStripComboBox();
            toolStripMenuItem1 = new ToolStripMenuItem();
            checkBox14 = new CheckBox();
            checkBox15 = new CheckBox();
            checkBox16 = new CheckBox();
            checkBox17 = new CheckBox();
            checkBox18 = new CheckBox();
            checkBox19 = new CheckBox();
            checkBox20 = new CheckBox();
            checkBox21 = new CheckBox();
            label1 = new Label();
            checkBox13 = new CheckBox();
            checkBox22 = new CheckBox();
            checkBox23 = new CheckBox();
            checkBox24 = new CheckBox();
            checkBox25 = new CheckBox();
            checkBox26 = new CheckBox();
            checkBox27 = new CheckBox();
            checkBox28 = new CheckBox();
            checkBox29 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(9, 629);
            checkBox1.Margin = new Padding(3, 4, 3, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 24);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Slow mode";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox1.ForeColor = SystemColors.GrayText;
            textBox1.Location = new Point(55, 50);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ScrollBars = ScrollBars.Horizontal;
            textBox1.Size = new Size(196, 60);
            textBox1.TabIndex = 1;
            textBox1.Text = "admin";
            textBox1.WordWrap = false;
            textBox1.Enter += textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(229, 629);
            checkBox2.Margin = new Padding(3, 4, 3, 4);
            checkBox2.Name = "checkBox2";
            checkBox2.RightToLeft = RightToLeft.Yes;
            checkBox2.Size = new Size(125, 24);
            checkBox2.TabIndex = 2;
            checkBox2.Text = "Always on top";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox2.ForeColor = SystemColors.GrayText;
            textBox2.Location = new Point(55, 114);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Horizontal;
            textBox2.Size = new Size(196, 57);
            textBox2.TabIndex = 7;
            textBox2.Text = "P@ssw0rd";
            textBox2.UseSystemPasswordChar = true;
            textBox2.WordWrap = false;
            textBox2.Enter += textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox3.Location = new Point(55, 178);
            textBox3.Margin = new Padding(3, 4, 3, 4);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.ScrollBars = ScrollBars.Horizontal;
            textBox3.Size = new Size(196, 60);
            textBox3.TabIndex = 7;
            textBox3.WordWrap = false;
            textBox3.Enter += textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            // 
            // checkBox5
            // 
            checkBox5.Appearance = Appearance.Button;
            checkBox5.BackgroundImage = (Image)resources.GetObject("checkBox5.BackgroundImage");
            checkBox5.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox5.CheckAlign = ContentAlignment.BottomLeft;
            checkBox5.FlatAppearance.BorderSize = 0;
            checkBox5.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox5.FlatStyle = FlatStyle.Flat;
            checkBox5.Location = new Point(9, 172);
            checkBox5.Margin = new Padding(0);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(40, 48);
            checkBox5.TabIndex = 8;
            checkBox5.UseVisualStyleBackColor = true;
            checkBox5.CheckedChanged += checkBox5_CheckedChanged;
            // 
            // checkBox4
            // 
            checkBox4.Appearance = Appearance.Button;
            checkBox4.BackgroundImage = (Image)resources.GetObject("checkBox4.BackgroundImage");
            checkBox4.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox4.CheckAlign = ContentAlignment.BottomLeft;
            checkBox4.FlatAppearance.BorderSize = 0;
            checkBox4.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox4.FlatStyle = FlatStyle.Flat;
            checkBox4.Location = new Point(9, 108);
            checkBox4.Margin = new Padding(0);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(40, 48);
            checkBox4.TabIndex = 8;
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.CheckedChanged += checkBox4_CheckedChanged;
            // 
            // checkBox3
            // 
            checkBox3.Appearance = Appearance.Button;
            checkBox3.BackgroundImage = (Image)resources.GetObject("checkBox3.BackgroundImage");
            checkBox3.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox3.CheckAlign = ContentAlignment.BottomLeft;
            checkBox3.FlatAppearance.BorderSize = 0;
            checkBox3.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox3.FlatStyle = FlatStyle.Flat;
            checkBox3.Location = new Point(9, 45);
            checkBox3.Margin = new Padding(0);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(40, 48);
            checkBox3.TabIndex = 3;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox6
            // 
            checkBox6.Appearance = Appearance.Button;
            checkBox6.BackgroundImage = (Image)resources.GetObject("checkBox6.BackgroundImage");
            checkBox6.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox6.CheckAlign = ContentAlignment.BottomLeft;
            checkBox6.FlatAppearance.BorderSize = 0;
            checkBox6.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox6.FlatStyle = FlatStyle.Flat;
            checkBox6.Location = new Point(9, 365);
            checkBox6.Margin = new Padding(0);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(40, 48);
            checkBox6.TabIndex = 15;
            checkBox6.UseVisualStyleBackColor = true;
            checkBox6.CheckedChanged += checkBox6_CheckedChanged;
            // 
            // textBox6
            // 
            textBox6.BorderStyle = BorderStyle.None;
            textBox6.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox6.Location = new Point(55, 370);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Multiline = true;
            textBox6.Name = "textBox6";
            textBox6.ScrollBars = ScrollBars.Horizontal;
            textBox6.Size = new Size(196, 60);
            textBox6.TabIndex = 13;
            textBox6.WordWrap = false;
            textBox6.Enter += textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            // 
            // checkBox7
            // 
            checkBox7.Appearance = Appearance.Button;
            checkBox7.BackgroundImage = (Image)resources.GetObject("checkBox7.BackgroundImage");
            checkBox7.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox7.CheckAlign = ContentAlignment.BottomLeft;
            checkBox7.FlatAppearance.BorderSize = 0;
            checkBox7.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox7.FlatStyle = FlatStyle.Flat;
            checkBox7.Location = new Point(9, 301);
            checkBox7.Margin = new Padding(0);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(40, 48);
            checkBox7.TabIndex = 16;
            checkBox7.UseVisualStyleBackColor = true;
            checkBox7.CheckedChanged += checkBox7_CheckedChanged;
            // 
            // textBox5
            // 
            textBox5.BorderStyle = BorderStyle.None;
            textBox5.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox5.Location = new Point(55, 306);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Multiline = true;
            textBox5.Name = "textBox5";
            textBox5.ScrollBars = ScrollBars.Horizontal;
            textBox5.Size = new Size(196, 60);
            textBox5.TabIndex = 14;
            textBox5.WordWrap = false;
            textBox5.Enter += textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            // 
            // checkBox8
            // 
            checkBox8.Appearance = Appearance.Button;
            checkBox8.BackgroundImage = (Image)resources.GetObject("checkBox8.BackgroundImage");
            checkBox8.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox8.CheckAlign = ContentAlignment.BottomLeft;
            checkBox8.FlatAppearance.BorderSize = 0;
            checkBox8.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox8.FlatStyle = FlatStyle.Flat;
            checkBox8.Location = new Point(9, 236);
            checkBox8.Margin = new Padding(0);
            checkBox8.Name = "checkBox8";
            checkBox8.Size = new Size(40, 48);
            checkBox8.TabIndex = 11;
            checkBox8.UseVisualStyleBackColor = true;
            checkBox8.CheckedChanged += checkBox8_CheckedChanged;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox4.Location = new Point(55, 242);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.ScrollBars = ScrollBars.Horizontal;
            textBox4.Size = new Size(196, 59);
            textBox4.TabIndex = 10;
            textBox4.WordWrap = false;
            textBox4.Enter += textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            // 
            // checkBox9
            // 
            checkBox9.Appearance = Appearance.Button;
            checkBox9.BackgroundImage = (Image)resources.GetObject("checkBox9.BackgroundImage");
            checkBox9.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox9.CheckAlign = ContentAlignment.BottomLeft;
            checkBox9.FlatAppearance.BorderSize = 0;
            checkBox9.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox9.FlatStyle = FlatStyle.Flat;
            checkBox9.Location = new Point(9, 559);
            checkBox9.Margin = new Padding(0);
            checkBox9.Name = "checkBox9";
            checkBox9.Size = new Size(40, 48);
            checkBox9.TabIndex = 15;
            checkBox9.UseVisualStyleBackColor = true;
            checkBox9.CheckedChanged += checkBox9_CheckedChanged;
            // 
            // textBox9
            // 
            textBox9.BorderStyle = BorderStyle.None;
            textBox9.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox9.Location = new Point(55, 564);
            textBox9.Margin = new Padding(3, 4, 3, 4);
            textBox9.Multiline = true;
            textBox9.Name = "textBox9";
            textBox9.ScrollBars = ScrollBars.Horizontal;
            textBox9.Size = new Size(196, 60);
            textBox9.TabIndex = 13;
            textBox9.WordWrap = false;
            textBox9.Enter += textBox9_Enter;
            textBox9.Leave += textBox9_Leave;
            // 
            // checkBox10
            // 
            checkBox10.Appearance = Appearance.Button;
            checkBox10.BackgroundImage = (Image)resources.GetObject("checkBox10.BackgroundImage");
            checkBox10.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox10.CheckAlign = ContentAlignment.BottomLeft;
            checkBox10.FlatAppearance.BorderSize = 0;
            checkBox10.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox10.FlatStyle = FlatStyle.Flat;
            checkBox10.Location = new Point(9, 495);
            checkBox10.Margin = new Padding(0);
            checkBox10.Name = "checkBox10";
            checkBox10.Size = new Size(40, 48);
            checkBox10.TabIndex = 16;
            checkBox10.UseVisualStyleBackColor = true;
            checkBox10.CheckedChanged += checkBox10_CheckedChanged;
            // 
            // textBox8
            // 
            textBox8.BorderStyle = BorderStyle.None;
            textBox8.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox8.Location = new Point(55, 500);
            textBox8.Margin = new Padding(3, 4, 3, 4);
            textBox8.Multiline = true;
            textBox8.Name = "textBox8";
            textBox8.ScrollBars = ScrollBars.Horizontal;
            textBox8.Size = new Size(196, 60);
            textBox8.TabIndex = 14;
            textBox8.WordWrap = false;
            textBox8.Enter += textBox8_Enter;
            textBox8.Leave += textBox8_Leave;
            // 
            // checkBox11
            // 
            checkBox11.Appearance = Appearance.Button;
            checkBox11.BackgroundImage = (Image)resources.GetObject("checkBox11.BackgroundImage");
            checkBox11.BackgroundImageLayout = ImageLayout.Stretch;
            checkBox11.CheckAlign = ContentAlignment.BottomLeft;
            checkBox11.FlatAppearance.BorderSize = 0;
            checkBox11.FlatAppearance.CheckedBackColor = Color.Green;
            checkBox11.FlatStyle = FlatStyle.Flat;
            checkBox11.Location = new Point(9, 429);
            checkBox11.Margin = new Padding(0);
            checkBox11.Name = "checkBox11";
            checkBox11.Size = new Size(40, 48);
            checkBox11.TabIndex = 11;
            checkBox11.UseVisualStyleBackColor = true;
            checkBox11.CheckedChanged += checkBox11_CheckedChanged;
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Font = new Font("Cambria", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBox7.Location = new Point(55, 435);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.ScrollBars = ScrollBars.Horizontal;
            textBox7.Size = new Size(196, 60);
            textBox7.TabIndex = 10;
            textBox7.WordWrap = false;
            textBox7.Enter += textBox7_Enter;
            textBox7.Leave += textBox7_Leave;
            // 
            // checkBox12
            // 
            checkBox12.Appearance = Appearance.Button;
            checkBox12.BackColor = Color.RoyalBlue;
            checkBox12.Checked = true;
            checkBox12.CheckState = CheckState.Checked;
            checkBox12.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox12.FlatStyle = FlatStyle.System;
            checkBox12.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox12.Location = new Point(249, 50);
            checkBox12.Margin = new Padding(3, 4, 3, 4);
            checkBox12.Name = "checkBox12";
            checkBox12.RightToLeft = RightToLeft.No;
            checkBox12.Size = new Size(27, 35);
            checkBox12.TabIndex = 19;
            checkBox12.Text = "👁";
            checkBox12.TextAlign = ContentAlignment.TopCenter;
            checkBox12.UseVisualStyleBackColor = false;
            checkBox12.CheckedChanged += checkBox12_CheckedChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { File, Profiles, Hotkeys });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.RenderMode = ToolStripRenderMode.Professional;
            menuStrip1.Size = new Size(353, 34);
            menuStrip1.TabIndex = 20;
            menuStrip1.Text = "menuStrip1";
            // 
            // File
            // 
            File.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, saveAsToolStripMenuItem, toolStripMenuItem3, createProfileToolStripMenuItem, deleteProfileToolStripMenuItem, fileToolStripMenuItem, aboutToolStripMenuItem });
            File.Name = "File";
            File.Size = new Size(46, 28);
            File.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(170, 26);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(170, 26);
            saveAsToolStripMenuItem.Text = "Save as...";
            saveAsToolStripMenuItem.Click += saveAsToolStripMenuItem_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(167, 6);
            // 
            // createProfileToolStripMenuItem
            // 
            createProfileToolStripMenuItem.Name = "createProfileToolStripMenuItem";
            createProfileToolStripMenuItem.Size = new Size(170, 26);
            createProfileToolStripMenuItem.Text = "New profile";
            createProfileToolStripMenuItem.Click += createProfileToolStripMenuItem_Click;
            // 
            // deleteProfileToolStripMenuItem
            // 
            deleteProfileToolStripMenuItem.Name = "deleteProfileToolStripMenuItem";
            deleteProfileToolStripMenuItem.Size = new Size(170, 26);
            deleteProfileToolStripMenuItem.Text = "Edit profile";
            deleteProfileToolStripMenuItem.Click += deleteProfileToolStripMenuItem_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(167, 6);
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(170, 26);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // Profiles
            // 
            Profiles.Name = "Profiles";
            Profiles.Size = new Size(150, 28);
            Profiles.Text = "Profile";
            Profiles.DropDown += Profiles_DropDown;
            Profiles.DropDownClosed += Profiles_DropDownClosed;
            Profiles.SelectedIndexChanged += Profiles_SelectedIndexChanged;
            Profiles.Click += Profiles_Click;
            // 
            // Hotkeys
            // 
            Hotkeys.Items.AddRange(new object[] { "Ctrl+Alt+Z", "Ctrl+Alt+X", "Ctrl+Alt+C", "Ctrl+Alt+V", "Ctrl+Alt+A", "Ctrl+Alt+S", "Ctrl+Alt+D", "Ctrl+Alt+F", "Ctrl+Alt+Q", "Ctrl+Alt+W", "Ctrl+Alt+E", "Ctrl+Alt+R" });
            Hotkeys.Name = "Hotkeys";
            Hotkeys.Size = new Size(100, 28);
            Hotkeys.Text = "Ctrl+Alt+V";
            Hotkeys.SelectedIndexChanged += Hotkeys_SelectedIndexChanged;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(32, 19);
            // 
            // checkBox14
            // 
            checkBox14.Appearance = Appearance.Button;
            checkBox14.BackColor = Color.RoyalBlue;
            checkBox14.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox14.FlatStyle = FlatStyle.System;
            checkBox14.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox14.Location = new Point(249, 114);
            checkBox14.Margin = new Padding(3, 4, 3, 4);
            checkBox14.Name = "checkBox14";
            checkBox14.RightToLeft = RightToLeft.No;
            checkBox14.Size = new Size(27, 35);
            checkBox14.TabIndex = 21;
            checkBox14.Text = "👁";
            checkBox14.TextAlign = ContentAlignment.TopCenter;
            checkBox14.UseVisualStyleBackColor = false;
            checkBox14.CheckedChanged += checkBox14_CheckedChanged;
            // 
            // checkBox15
            // 
            checkBox15.Appearance = Appearance.Button;
            checkBox15.BackColor = Color.RoyalBlue;
            checkBox15.Checked = true;
            checkBox15.CheckState = CheckState.Checked;
            checkBox15.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox15.FlatStyle = FlatStyle.System;
            checkBox15.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox15.Location = new Point(249, 178);
            checkBox15.Margin = new Padding(3, 4, 3, 4);
            checkBox15.Name = "checkBox15";
            checkBox15.RightToLeft = RightToLeft.No;
            checkBox15.Size = new Size(27, 35);
            checkBox15.TabIndex = 22;
            checkBox15.Text = "👁";
            checkBox15.TextAlign = ContentAlignment.TopCenter;
            checkBox15.UseVisualStyleBackColor = false;
            checkBox15.CheckedChanged += checkBox15_CheckedChanged;
            // 
            // checkBox16
            // 
            checkBox16.Appearance = Appearance.Button;
            checkBox16.BackColor = Color.RoyalBlue;
            checkBox16.Checked = true;
            checkBox16.CheckState = CheckState.Checked;
            checkBox16.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox16.FlatStyle = FlatStyle.System;
            checkBox16.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox16.Location = new Point(249, 242);
            checkBox16.Margin = new Padding(3, 4, 3, 4);
            checkBox16.Name = "checkBox16";
            checkBox16.RightToLeft = RightToLeft.No;
            checkBox16.Size = new Size(27, 35);
            checkBox16.TabIndex = 23;
            checkBox16.Text = "👁";
            checkBox16.TextAlign = ContentAlignment.TopCenter;
            checkBox16.UseVisualStyleBackColor = false;
            checkBox16.CheckedChanged += checkBox16_CheckedChanged;
            // 
            // checkBox17
            // 
            checkBox17.Appearance = Appearance.Button;
            checkBox17.BackColor = Color.RoyalBlue;
            checkBox17.Checked = true;
            checkBox17.CheckState = CheckState.Checked;
            checkBox17.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox17.FlatStyle = FlatStyle.System;
            checkBox17.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox17.Location = new Point(249, 306);
            checkBox17.Margin = new Padding(3, 4, 3, 4);
            checkBox17.Name = "checkBox17";
            checkBox17.RightToLeft = RightToLeft.No;
            checkBox17.Size = new Size(27, 35);
            checkBox17.TabIndex = 24;
            checkBox17.Text = "👁";
            checkBox17.TextAlign = ContentAlignment.TopCenter;
            checkBox17.UseVisualStyleBackColor = false;
            checkBox17.CheckedChanged += checkBox17_CheckedChanged;
            // 
            // checkBox18
            // 
            checkBox18.Appearance = Appearance.Button;
            checkBox18.BackColor = Color.RoyalBlue;
            checkBox18.Checked = true;
            checkBox18.CheckState = CheckState.Checked;
            checkBox18.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox18.FlatStyle = FlatStyle.System;
            checkBox18.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox18.Location = new Point(249, 370);
            checkBox18.Margin = new Padding(3, 4, 3, 4);
            checkBox18.Name = "checkBox18";
            checkBox18.RightToLeft = RightToLeft.No;
            checkBox18.Size = new Size(27, 35);
            checkBox18.TabIndex = 25;
            checkBox18.Text = "👁";
            checkBox18.TextAlign = ContentAlignment.TopCenter;
            checkBox18.UseVisualStyleBackColor = false;
            checkBox18.CheckedChanged += checkBox18_CheckedChanged;
            // 
            // checkBox19
            // 
            checkBox19.Appearance = Appearance.Button;
            checkBox19.BackColor = Color.RoyalBlue;
            checkBox19.Checked = true;
            checkBox19.CheckState = CheckState.Checked;
            checkBox19.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox19.FlatStyle = FlatStyle.System;
            checkBox19.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox19.Location = new Point(249, 435);
            checkBox19.Margin = new Padding(3, 4, 3, 4);
            checkBox19.Name = "checkBox19";
            checkBox19.RightToLeft = RightToLeft.No;
            checkBox19.Size = new Size(27, 35);
            checkBox19.TabIndex = 26;
            checkBox19.Text = "👁";
            checkBox19.TextAlign = ContentAlignment.TopCenter;
            checkBox19.UseVisualStyleBackColor = false;
            checkBox19.CheckedChanged += checkBox19_CheckedChanged;
            // 
            // checkBox20
            // 
            checkBox20.Appearance = Appearance.Button;
            checkBox20.BackColor = Color.RoyalBlue;
            checkBox20.Checked = true;
            checkBox20.CheckState = CheckState.Checked;
            checkBox20.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox20.FlatStyle = FlatStyle.System;
            checkBox20.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox20.Location = new Point(249, 500);
            checkBox20.Margin = new Padding(3, 4, 3, 4);
            checkBox20.Name = "checkBox20";
            checkBox20.RightToLeft = RightToLeft.No;
            checkBox20.Size = new Size(27, 35);
            checkBox20.TabIndex = 27;
            checkBox20.Text = "👁";
            checkBox20.TextAlign = ContentAlignment.TopCenter;
            checkBox20.UseVisualStyleBackColor = false;
            checkBox20.CheckedChanged += checkBox20_CheckedChanged;
            // 
            // checkBox21
            // 
            checkBox21.Appearance = Appearance.Button;
            checkBox21.BackColor = Color.RoyalBlue;
            checkBox21.Checked = true;
            checkBox21.CheckState = CheckState.Checked;
            checkBox21.FlatAppearance.BorderColor = Color.DarkGray;
            checkBox21.FlatStyle = FlatStyle.System;
            checkBox21.Font = new Font("Ink Free", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox21.Location = new Point(249, 564);
            checkBox21.Margin = new Padding(3, 4, 3, 4);
            checkBox21.Name = "checkBox21";
            checkBox21.RightToLeft = RightToLeft.No;
            checkBox21.Size = new Size(27, 35);
            checkBox21.TabIndex = 28;
            checkBox21.Text = "👁";
            checkBox21.TextAlign = ContentAlignment.TopCenter;
            checkBox21.UseVisualStyleBackColor = false;
            checkBox21.CheckedChanged += checkBox21_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ActiveCaption;
            label1.Location = new Point(437, 615);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 29;
            label1.Text = "label";
            // 
            // checkBox13
            // 
            checkBox13.Appearance = Appearance.Button;
            checkBox13.BackColor = Color.White;
            checkBox13.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox13.Checked = true;
            checkBox13.CheckState = CheckState.Checked;
            checkBox13.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox13.FlatAppearance.BorderSize = 4;
            checkBox13.FlatStyle = FlatStyle.Flat;
            checkBox13.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox13.ForeColor = Color.White;
            checkBox13.Location = new Point(276, 41);
            checkBox13.Name = "checkBox13";
            checkBox13.RightToLeft = RightToLeft.No;
            checkBox13.Size = new Size(76, 58);
            checkBox13.TabIndex = 30;
            checkBox13.Text = "↹ TAB";
            checkBox13.UseVisualStyleBackColor = false;
            checkBox13.CheckedChanged += checkBox13_CheckedChanged;
            // 
            // checkBox22
            // 
            checkBox22.Appearance = Appearance.Button;
            checkBox22.BackColor = Color.White;
            checkBox22.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox22.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox22.FlatAppearance.BorderSize = 4;
            checkBox22.FlatStyle = FlatStyle.Flat;
            checkBox22.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox22.ForeColor = Color.White;
            checkBox22.Location = new Point(276, 105);
            checkBox22.Name = "checkBox22";
            checkBox22.RightToLeft = RightToLeft.No;
            checkBox22.Size = new Size(76, 58);
            checkBox22.TabIndex = 31;
            checkBox22.Text = "↹ TAB";
            checkBox22.UseVisualStyleBackColor = false;
            checkBox22.CheckedChanged += checkBox22_CheckedChanged;
            // 
            // checkBox23
            // 
            checkBox23.Appearance = Appearance.Button;
            checkBox23.BackColor = Color.White;
            checkBox23.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox23.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox23.FlatAppearance.BorderSize = 4;
            checkBox23.FlatStyle = FlatStyle.Flat;
            checkBox23.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox23.ForeColor = Color.White;
            checkBox23.Location = new Point(276, 169);
            checkBox23.Name = "checkBox23";
            checkBox23.RightToLeft = RightToLeft.No;
            checkBox23.Size = new Size(76, 58);
            checkBox23.TabIndex = 32;
            checkBox23.Text = "↹ TAB";
            checkBox23.UseVisualStyleBackColor = false;
            checkBox23.CheckedChanged += checkBox23_CheckedChanged;
            // 
            // checkBox24
            // 
            checkBox24.Appearance = Appearance.Button;
            checkBox24.BackColor = Color.White;
            checkBox24.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox24.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox24.FlatAppearance.BorderSize = 4;
            checkBox24.FlatStyle = FlatStyle.Flat;
            checkBox24.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox24.ForeColor = Color.White;
            checkBox24.Location = new Point(276, 233);
            checkBox24.Name = "checkBox24";
            checkBox24.RightToLeft = RightToLeft.No;
            checkBox24.Size = new Size(76, 58);
            checkBox24.TabIndex = 33;
            checkBox24.Text = "↹ TAB";
            checkBox24.UseVisualStyleBackColor = false;
            checkBox24.CheckedChanged += checkBox24_CheckedChanged;
            // 
            // checkBox25
            // 
            checkBox25.Appearance = Appearance.Button;
            checkBox25.BackColor = Color.White;
            checkBox25.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox25.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox25.FlatAppearance.BorderSize = 4;
            checkBox25.FlatStyle = FlatStyle.Flat;
            checkBox25.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox25.ForeColor = Color.White;
            checkBox25.Location = new Point(276, 297);
            checkBox25.Name = "checkBox25";
            checkBox25.RightToLeft = RightToLeft.No;
            checkBox25.Size = new Size(76, 58);
            checkBox25.TabIndex = 34;
            checkBox25.Text = "↹ TAB";
            checkBox25.UseVisualStyleBackColor = false;
            checkBox25.CheckedChanged += checkBox25_CheckedChanged;
            // 
            // checkBox26
            // 
            checkBox26.Appearance = Appearance.Button;
            checkBox26.BackColor = Color.White;
            checkBox26.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox26.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox26.FlatAppearance.BorderSize = 4;
            checkBox26.FlatStyle = FlatStyle.Flat;
            checkBox26.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox26.ForeColor = Color.White;
            checkBox26.Location = new Point(276, 361);
            checkBox26.Name = "checkBox26";
            checkBox26.RightToLeft = RightToLeft.No;
            checkBox26.Size = new Size(76, 58);
            checkBox26.TabIndex = 35;
            checkBox26.Text = "↹ TAB";
            checkBox26.UseVisualStyleBackColor = false;
            checkBox26.CheckedChanged += checkBox26_CheckedChanged;
            // 
            // checkBox27
            // 
            checkBox27.Appearance = Appearance.Button;
            checkBox27.BackColor = Color.White;
            checkBox27.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox27.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox27.FlatAppearance.BorderSize = 4;
            checkBox27.FlatStyle = FlatStyle.Flat;
            checkBox27.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox27.ForeColor = Color.White;
            checkBox27.Location = new Point(276, 426);
            checkBox27.Name = "checkBox27";
            checkBox27.RightToLeft = RightToLeft.No;
            checkBox27.Size = new Size(76, 58);
            checkBox27.TabIndex = 36;
            checkBox27.Text = "↹ TAB";
            checkBox27.UseVisualStyleBackColor = false;
            checkBox27.CheckedChanged += checkBox27_CheckedChanged;
            // 
            // checkBox28
            // 
            checkBox28.Appearance = Appearance.Button;
            checkBox28.BackColor = Color.White;
            checkBox28.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox28.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox28.FlatAppearance.BorderSize = 4;
            checkBox28.FlatStyle = FlatStyle.Flat;
            checkBox28.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox28.ForeColor = Color.White;
            checkBox28.Location = new Point(276, 491);
            checkBox28.Name = "checkBox28";
            checkBox28.RightToLeft = RightToLeft.No;
            checkBox28.Size = new Size(76, 58);
            checkBox28.TabIndex = 37;
            checkBox28.Text = "↹ TAB";
            checkBox28.UseVisualStyleBackColor = false;
            checkBox28.CheckedChanged += checkBox28_CheckedChanged;
            // 
            // checkBox29
            // 
            checkBox29.Appearance = Appearance.Button;
            checkBox29.BackColor = Color.White;
            checkBox29.CheckAlign = ContentAlignment.MiddleCenter;
            checkBox29.FlatAppearance.BorderColor = Color.AliceBlue;
            checkBox29.FlatAppearance.BorderSize = 4;
            checkBox29.FlatStyle = FlatStyle.Flat;
            checkBox29.Font = new Font("Franklin Gothic Medium", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            checkBox29.ForeColor = Color.White;
            checkBox29.Location = new Point(276, 555);
            checkBox29.Name = "checkBox29";
            checkBox29.RightToLeft = RightToLeft.No;
            checkBox29.Size = new Size(76, 58);
            checkBox29.TabIndex = 38;
            checkBox29.Text = "↹ TAB";
            checkBox29.UseVisualStyleBackColor = false;
            checkBox29.CheckedChanged += checkBox29_CheckedChanged;
            // 
            // button1
            // 
            button1.BackgroundImage = (Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(311, 0);
            button1.Name = "button1";
            button1.Size = new Size(34, 40);
            button1.TabIndex = 39;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(148, 624);
            button2.Name = "button2";
            button2.Size = new Size(55, 29);
            button2.TabIndex = 40;
            button2.Text = "Color";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            button2.Leave += button2_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(406, 508);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 41;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(406, 393);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 42;
            label3.Text = "label3";
            // 
            // infill
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(353, 660);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox29);
            Controls.Add(checkBox28);
            Controls.Add(checkBox27);
            Controls.Add(checkBox26);
            Controls.Add(checkBox25);
            Controls.Add(checkBox24);
            Controls.Add(checkBox23);
            Controls.Add(checkBox22);
            Controls.Add(checkBox13);
            Controls.Add(label1);
            Controls.Add(checkBox21);
            Controls.Add(checkBox20);
            Controls.Add(checkBox19);
            Controls.Add(checkBox18);
            Controls.Add(checkBox17);
            Controls.Add(checkBox16);
            Controls.Add(checkBox15);
            Controls.Add(checkBox14);
            Controls.Add(textBox2);
            Controls.Add(checkBox12);
            Controls.Add(checkBox9);
            Controls.Add(checkBox6);
            Controls.Add(textBox9);
            Controls.Add(checkBox5);
            Controls.Add(checkBox10);
            Controls.Add(textBox8);
            Controls.Add(checkBox11);
            Controls.Add(textBox6);
            Controls.Add(textBox7);
            Controls.Add(textBox3);
            Controls.Add(checkBox7);
            Controls.Add(checkBox4);
            Controls.Add(textBox5);
            Controls.Add(checkBox8);
            Controls.Add(textBox4);
            Controls.Add(checkBox3);
            Controls.Add(checkBox2);
            Controls.Add(textBox1);
            Controls.Add(checkBox1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "infill";
            Opacity = 0.94D;
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "infill | Ctrl+Alt+V";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton radioButton7;
        private System.Windows.Forms.RadioButton radioButton8;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton radioButton9;
        private System.Windows.Forms.RadioButton radioButton10;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton radioButton11;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton radioButton13;
        private System.Windows.Forms.RadioButton radioButton14;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.RadioButton radioButton15;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.RadioButton radioButton17;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem File;
        private System.Windows.Forms.ToolStripComboBox Profiles;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox Hotkeys;
        private System.Windows.Forms.ToolStripMenuItem createProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteProfileToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox17;
        private System.Windows.Forms.CheckBox checkBox18;
        private System.Windows.Forms.CheckBox checkBox19;
        private System.Windows.Forms.CheckBox checkBox20;
        private System.Windows.Forms.CheckBox checkBox21;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem3;
        private RadioButton radioButton16;
        private Label label1;
        private ToolStripSeparator fileToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private RadioButton radioButton6;
        private CheckBox checkBox13;
        private CheckBox checkBox22;
        private CheckBox checkBox23;
        private CheckBox checkBox24;
        private CheckBox checkBox25;
        private CheckBox checkBox26;
        private CheckBox checkBox27;
        private CheckBox checkBox28;
        private CheckBox checkBox29;
        private RadioButton radioButton1;
        private Button button1;
        private Button button2;
        private Label label2;
        private Label label3;
    }
}

