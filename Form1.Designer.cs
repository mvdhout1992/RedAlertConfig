using System.Diagnostics;

namespace RedAlertConfig
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_Cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.chb_StandaloneExpanionMaps = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label36 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.chb_ForceAfermath = new System.Windows.Forms.Label();
            this.chb_ForceAftermathOnline = new System.Windows.Forms.CheckBox();
            this.but_RunCnCNetSetup = new System.Windows.Forms.Button();
            this.link_CnCNetSite = new System.Windows.Forms.LinkLabel();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbox_Color = new System.Windows.Forms.ComboBox();
            this.cmbox_Side = new System.Windows.Forms.ComboBox();
            this.txtb_Handle = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chb_UseLanPatch = new System.Windows.Forms.CheckBox();
            this.chb_EnableSmallInfantry = new System.Windows.Forms.CheckBox();
            this.chb_PlayIntro = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Slider_MusicVolume = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.slider_SoundVolume = new System.Windows.Forms.TrackBar();
            this.chb_RepeatMusic = new System.Windows.Forms.CheckBox();
            this.chb_ShuffleMusic = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.slider_GameSpeed = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.slider_ScrollRate = new System.Windows.Forms.TrackBar();
            this.chb_PaletteScroll = new System.Windows.Forms.CheckBox();
            this.chb_Autoscroll = new System.Windows.Forms.CheckBox();
            this.chb_EnableAftermath = new System.Windows.Forms.CheckBox();
            this.chb_EnableCounterstrike = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtb_MaxFPS = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radiob_RendererOpenGL = new System.Windows.Forms.RadioButton();
            this.radiob_RendererGDI = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtb_resoCustomHeight = new System.Windows.Forms.TextBox();
            this.radiob_reso640x400 = new System.Windows.Forms.RadioButton();
            this.txtb_resoCustomWidth = new System.Windows.Forms.TextBox();
            this.radiob_reso640x480 = new System.Windows.Forms.RadioButton();
            this.label17 = new System.Windows.Forms.Label();
            this.radiob_reso800x600 = new System.Windows.Forms.RadioButton();
            this.radiob_resoCustom = new System.Windows.Forms.RadioButton();
            this.radiob_reso1024x768 = new System.Windows.Forms.RadioButton();
            this.but_DetectReso = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.chb_UseWindowBoxing = new System.Windows.Forms.CheckBox();
            this.chb_ShowWindowedBorder = new System.Windows.Forms.CheckBox();
            this.label33 = new System.Windows.Forms.Label();
            this.cmbox_BitsPerPixels = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.chb_EnableMouseHack = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.chb_ForceSingleCPU = new System.Windows.Forms.CheckBox();
            this.chb_EnableVSync = new System.Windows.Forms.CheckBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.chb_AutoAdjustMouse = new System.Windows.Forms.CheckBox();
            this.chb_RunWindowed = new System.Windows.Forms.CheckBox();
            this.chb_AllowHardwareFilledBits = new System.Windows.Forms.CheckBox();
            this.chb_BackBufferVideoMemory = new System.Windows.Forms.CheckBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_StretchingScaling = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbox_ScalingFilter = new System.Windows.Forms.ComboBox();
            this.chb_StretchCustom = new System.Windows.Forms.CheckBox();
            this.txtb_StretchCustomHeight = new System.Windows.Forms.TextBox();
            this.txtb_StretchCustomWidth = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_UseRAAspectRatio = new System.Windows.Forms.Label();
            this.chb_UseRAAspectRatio = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_EnableCnCDDraw = new System.Windows.Forms.CheckBox();
            this.tabPage5.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_MusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_GameSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ScrollRate)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Cancel
            // 
            this.but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Cancel.Location = new System.Drawing.Point(415, 430);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 2;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(324, 430);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 3;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 22);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(471, 386);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "About";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.checkBox1);
            this.tabPage5.Controls.Add(this.chb_StandaloneExpanionMaps);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(471, 386);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Map list";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(18, 49);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(331, 17);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "note to self: add .INI versions of expnsions map back to MIX files";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // chb_StandaloneExpanionMaps
            // 
            this.chb_StandaloneExpanionMaps.AutoSize = true;
            this.chb_StandaloneExpanionMaps.Location = new System.Drawing.Point(18, 13);
            this.chb_StandaloneExpanionMaps.Name = "chb_StandaloneExpanionMaps";
            this.chb_StandaloneExpanionMaps.Size = new System.Drawing.Size(322, 17);
            this.chb_StandaloneExpanionMaps.TabIndex = 0;
            this.chb_StandaloneExpanionMaps.Text = "Enable custom expansions map pack with expansions disabled";
            this.chb_StandaloneExpanionMaps.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(471, 386);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hotkey editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.chb_ForceAfermath);
            this.tabPage3.Controls.Add(this.chb_ForceAftermathOnline);
            this.tabPage3.Controls.Add(this.but_RunCnCNetSetup);
            this.tabPage3.Controls.Add(this.link_CnCNetSite);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.cmbox_Color);
            this.tabPage3.Controls.Add(this.cmbox_Side);
            this.tabPage3.Controls.Add(this.txtb_Handle);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(471, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Multiplayer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(29, 140);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(191, 13);
            this.label36.TabIndex = 47;
            this.label36.Text = "Open cncnet.exe to start playing online";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(9, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Other:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(54, 245);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(159, 13);
            this.label15.TabIndex = 45;
            this.label15.Text = "Force Aftermath expanion online";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // chb_ForceAfermath
            // 
            this.chb_ForceAfermath.AutoSize = true;
            this.chb_ForceAfermath.Location = new System.Drawing.Point(54, 258);
            this.chb_ForceAfermath.Name = "chb_ForceAfermath";
            this.chb_ForceAfermath.Size = new System.Drawing.Size(253, 13);
            this.chb_ForceAfermath.TabIndex = 44;
            this.chb_ForceAfermath.Text = "(other players also need to have this option enabled)";
            this.chb_ForceAfermath.Click += new System.EventHandler(this.label14_Click);
            // 
            // chb_ForceAftermathOnline
            // 
            this.chb_ForceAftermathOnline.AutoSize = true;
            this.chb_ForceAftermathOnline.Location = new System.Drawing.Point(32, 252);
            this.chb_ForceAftermathOnline.Name = "chb_ForceAftermathOnline";
            this.chb_ForceAftermathOnline.Size = new System.Drawing.Size(15, 14);
            this.chb_ForceAftermathOnline.TabIndex = 43;
            this.chb_ForceAftermathOnline.UseVisualStyleBackColor = true;
            this.chb_ForceAftermathOnline.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // but_RunCnCNetSetup
            // 
            this.but_RunCnCNetSetup.Location = new System.Drawing.Point(32, 182);
            this.but_RunCnCNetSetup.Name = "but_RunCnCNetSetup";
            this.but_RunCnCNetSetup.Size = new System.Drawing.Size(111, 23);
            this.but_RunCnCNetSetup.TabIndex = 42;
            this.but_RunCnCNetSetup.Text = "Run CnCNet setup";
            this.but_RunCnCNetSetup.UseVisualStyleBackColor = true;
            this.but_RunCnCNetSetup.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // link_CnCNetSite
            // 
            this.link_CnCNetSite.AutoSize = true;
            this.link_CnCNetSite.LinkArea = new System.Windows.Forms.LinkArea(0, 38);
            this.link_CnCNetSite.Location = new System.Drawing.Point(29, 157);
            this.link_CnCNetSite.Name = "link_CnCNetSite";
            this.link_CnCNetSite.Size = new System.Drawing.Size(184, 13);
            this.link_CnCNetSite.TabIndex = 41;
            this.link_CnCNetSite.TabStop = true;
            this.link_CnCNetSite.Text = "Click here to visit the CnCNet website";
            this.link_CnCNetSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked_1);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label13.Location = new System.Drawing.Point(9, 116);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "CnCNet options:";
            // 
            // cmbox_Color
            // 
            this.cmbox_Color.FormattingEnabled = true;
            this.cmbox_Color.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "Green",
            "Orange",
            "Grey",
            "DarkGreen",
            "DarkRed"});
            this.cmbox_Color.Location = new System.Drawing.Point(170, 81);
            this.cmbox_Color.Name = "cmbox_Color";
            this.cmbox_Color.Size = new System.Drawing.Size(121, 21);
            this.cmbox_Color.TabIndex = 39;
            // 
            // cmbox_Side
            // 
            this.cmbox_Side.FormattingEnabled = true;
            this.cmbox_Side.Items.AddRange(new object[] {
            "Russia",
            "England",
            "Ukraine",
            "Germany",
            "France"});
            this.cmbox_Side.Location = new System.Drawing.Point(170, 56);
            this.cmbox_Side.Name = "cmbox_Side";
            this.cmbox_Side.Size = new System.Drawing.Size(121, 21);
            this.cmbox_Side.TabIndex = 38;
            // 
            // txtb_Handle
            // 
            this.txtb_Handle.Location = new System.Drawing.Point(170, 32);
            this.txtb_Handle.Name = "txtb_Handle";
            this.txtb_Handle.Size = new System.Drawing.Size(100, 20);
            this.txtb_Handle.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(29, 89);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Color:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Side:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 39);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Nickname";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(9, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Player information:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.chb_UseLanPatch);
            this.tabPage2.Controls.Add(this.chb_EnableSmallInfantry);
            this.tabPage2.Controls.Add(this.chb_PlayIntro);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.Slider_MusicVolume);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.slider_SoundVolume);
            this.tabPage2.Controls.Add(this.chb_RepeatMusic);
            this.tabPage2.Controls.Add(this.chb_ShuffleMusic);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.slider_GameSpeed);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.slider_ScrollRate);
            this.tabPage2.Controls.Add(this.chb_PaletteScroll);
            this.tabPage2.Controls.Add(this.chb_Autoscroll);
            this.tabPage2.Controls.Add(this.chb_EnableAftermath);
            this.tabPage2.Controls.Add(this.chb_EnableCounterstrike);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(471, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "General:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(9, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Expansions:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(9, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Scrolling and speed:";
            // 
            // chb_UseLanPatch
            // 
            this.chb_UseLanPatch.AutoSize = true;
            this.chb_UseLanPatch.Location = new System.Drawing.Point(29, 62);
            this.chb_UseLanPatch.Name = "chb_UseLanPatch";
            this.chb_UseLanPatch.Size = new System.Drawing.Size(155, 17);
            this.chb_UseLanPatch.TabIndex = 29;
            this.chb_UseLanPatch.Text = "Use LAN patch (thipx32.dll)";
            this.chb_UseLanPatch.UseVisualStyleBackColor = true;
            // 
            // chb_EnableSmallInfantry
            // 
            this.chb_EnableSmallInfantry.AutoSize = true;
            this.chb_EnableSmallInfantry.Location = new System.Drawing.Point(29, 39);
            this.chb_EnableSmallInfantry.Name = "chb_EnableSmallInfantry";
            this.chb_EnableSmallInfantry.Size = new System.Drawing.Size(177, 17);
            this.chb_EnableSmallInfantry.TabIndex = 28;
            this.chb_EnableSmallInfantry.Text = "Enable small infantry (hires1.mix)";
            this.chb_EnableSmallInfantry.UseVisualStyleBackColor = true;
            this.chb_EnableSmallInfantry.CheckedChanged += new System.EventHandler(this.chb_EnableSmallInfantry_CheckedChanged);
            // 
            // chb_PlayIntro
            // 
            this.chb_PlayIntro.AutoSize = true;
            this.chb_PlayIntro.Location = new System.Drawing.Point(29, 85);
            this.chb_PlayIntro.Name = "chb_PlayIntro";
            this.chb_PlayIntro.Size = new System.Drawing.Size(117, 17);
            this.chb_PlayIntro.TabIndex = 27;
            this.chb_PlayIntro.Text = "Play intro cinematic";
            this.chb_PlayIntro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Music volume:";
            // 
            // Slider_MusicVolume
            // 
            this.Slider_MusicVolume.AutoSize = false;
            this.Slider_MusicVolume.LargeChange = 1;
            this.Slider_MusicVolume.Location = new System.Drawing.Point(112, 344);
            this.Slider_MusicVolume.Maximum = 1000;
            this.Slider_MusicVolume.Name = "Slider_MusicVolume";
            this.Slider_MusicVolume.RightToLeftLayout = true;
            this.Slider_MusicVolume.Size = new System.Drawing.Size(153, 27);
            this.Slider_MusicVolume.SmallChange = 10;
            this.Slider_MusicVolume.TabIndex = 25;
            this.Slider_MusicVolume.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 316);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sound volume:";
            // 
            // slider_SoundVolume
            // 
            this.slider_SoundVolume.AutoSize = false;
            this.slider_SoundVolume.LargeChange = 1;
            this.slider_SoundVolume.Location = new System.Drawing.Point(112, 311);
            this.slider_SoundVolume.Maximum = 1000;
            this.slider_SoundVolume.Name = "slider_SoundVolume";
            this.slider_SoundVolume.RightToLeftLayout = true;
            this.slider_SoundVolume.Size = new System.Drawing.Size(153, 27);
            this.slider_SoundVolume.SmallChange = 10;
            this.slider_SoundVolume.TabIndex = 23;
            this.slider_SoundVolume.Value = 1;
            // 
            // chb_RepeatMusic
            // 
            this.chb_RepeatMusic.AutoSize = true;
            this.chb_RepeatMusic.Location = new System.Drawing.Point(284, 344);
            this.chb_RepeatMusic.Name = "chb_RepeatMusic";
            this.chb_RepeatMusic.Size = new System.Drawing.Size(91, 17);
            this.chb_RepeatMusic.TabIndex = 22;
            this.chb_RepeatMusic.Text = "Repeat music";
            this.chb_RepeatMusic.UseVisualStyleBackColor = true;
            // 
            // chb_ShuffleMusic
            // 
            this.chb_ShuffleMusic.AutoSize = true;
            this.chb_ShuffleMusic.Location = new System.Drawing.Point(284, 321);
            this.chb_ShuffleMusic.Name = "chb_ShuffleMusic";
            this.chb_ShuffleMusic.Size = new System.Drawing.Size(89, 17);
            this.chb_ShuffleMusic.TabIndex = 21;
            this.chb_ShuffleMusic.Text = "Shuffle music";
            this.chb_ShuffleMusic.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Game speed:";
            // 
            // slider_GameSpeed
            // 
            this.slider_GameSpeed.AutoSize = false;
            this.slider_GameSpeed.LargeChange = 1;
            this.slider_GameSpeed.Location = new System.Drawing.Point(112, 246);
            this.slider_GameSpeed.Maximum = 6;
            this.slider_GameSpeed.Name = "slider_GameSpeed";
            this.slider_GameSpeed.RightToLeftLayout = true;
            this.slider_GameSpeed.Size = new System.Drawing.Size(153, 27);
            this.slider_GameSpeed.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Scroll rate:";
            // 
            // slider_ScrollRate
            // 
            this.slider_ScrollRate.AutoSize = false;
            this.slider_ScrollRate.LargeChange = 1;
            this.slider_ScrollRate.Location = new System.Drawing.Point(112, 213);
            this.slider_ScrollRate.Maximum = 6;
            this.slider_ScrollRate.Name = "slider_ScrollRate";
            this.slider_ScrollRate.RightToLeftLayout = true;
            this.slider_ScrollRate.Size = new System.Drawing.Size(153, 27);
            this.slider_ScrollRate.TabIndex = 17;
            // 
            // chb_PaletteScroll
            // 
            this.chb_PaletteScroll.AutoSize = true;
            this.chb_PaletteScroll.Location = new System.Drawing.Point(284, 246);
            this.chb_PaletteScroll.Name = "chb_PaletteScroll";
            this.chb_PaletteScroll.Size = new System.Drawing.Size(86, 17);
            this.chb_PaletteScroll.TabIndex = 16;
            this.chb_PaletteScroll.Text = "Palette scroll";
            this.chb_PaletteScroll.UseVisualStyleBackColor = true;
            this.chb_PaletteScroll.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // chb_Autoscroll
            // 
            this.chb_Autoscroll.AutoSize = true;
            this.chb_Autoscroll.Location = new System.Drawing.Point(284, 223);
            this.chb_Autoscroll.Name = "chb_Autoscroll";
            this.chb_Autoscroll.Size = new System.Drawing.Size(75, 17);
            this.chb_Autoscroll.TabIndex = 15;
            this.chb_Autoscroll.Text = "Auto scroll";
            this.chb_Autoscroll.UseVisualStyleBackColor = true;
            // 
            // chb_EnableAftermath
            // 
            this.chb_EnableAftermath.AutoSize = true;
            this.chb_EnableAftermath.Location = new System.Drawing.Point(29, 162);
            this.chb_EnableAftermath.Name = "chb_EnableAftermath";
            this.chb_EnableAftermath.Size = new System.Drawing.Size(175, 17);
            this.chb_EnableAftermath.TabIndex = 14;
            this.chb_EnableAftermath.Text = "Enable Aftermath (expand2.mix)";
            this.chb_EnableAftermath.UseVisualStyleBackColor = true;
            this.chb_EnableAftermath.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // chb_EnableCounterstrike
            // 
            this.chb_EnableCounterstrike.AutoSize = true;
            this.chb_EnableCounterstrike.Location = new System.Drawing.Point(29, 139);
            this.chb_EnableCounterstrike.Name = "chb_EnableCounterstrike";
            this.chb_EnableCounterstrike.Size = new System.Drawing.Size(186, 17);
            this.chb_EnableCounterstrike.TabIndex = 13;
            this.chb_EnableCounterstrike.Text = "Enable Counterstrike (expand.mix)";
            this.chb_EnableCounterstrike.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(9, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sound options:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(479, 412);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtb_MaxFPS);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.but_DetectReso);
            this.tabPage1.Controls.Add(this.label34);
            this.tabPage1.Controls.Add(this.label35);
            this.tabPage1.Controls.Add(this.chb_UseWindowBoxing);
            this.tabPage1.Controls.Add(this.chb_ShowWindowedBorder);
            this.tabPage1.Controls.Add(this.label33);
            this.tabPage1.Controls.Add(this.cmbox_BitsPerPixels);
            this.tabPage1.Controls.Add(this.label31);
            this.tabPage1.Controls.Add(this.label32);
            this.tabPage1.Controls.Add(this.chb_EnableMouseHack);
            this.tabPage1.Controls.Add(this.label29);
            this.tabPage1.Controls.Add(this.label30);
            this.tabPage1.Controls.Add(this.chb_ForceSingleCPU);
            this.tabPage1.Controls.Add(this.chb_EnableVSync);
            this.tabPage1.Controls.Add(this.label25);
            this.tabPage1.Controls.Add(this.label26);
            this.tabPage1.Controls.Add(this.chb_AutoAdjustMouse);
            this.tabPage1.Controls.Add(this.chb_RunWindowed);
            this.tabPage1.Controls.Add(this.chb_AllowHardwareFilledBits);
            this.tabPage1.Controls.Add(this.chb_BackBufferVideoMemory);
            this.tabPage1.Controls.Add(this.label24);
            this.tabPage1.Controls.Add(this.txt_StretchingScaling);
            this.tabPage1.Controls.Add(this.label22);
            this.tabPage1.Controls.Add(this.label21);
            this.tabPage1.Controls.Add(this.cmbox_ScalingFilter);
            this.tabPage1.Controls.Add(this.chb_StretchCustom);
            this.tabPage1.Controls.Add(this.txtb_StretchCustomHeight);
            this.tabPage1.Controls.Add(this.txtb_StretchCustomWidth);
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txt_UseRAAspectRatio);
            this.tabPage1.Controls.Add(this.chb_UseRAAspectRatio);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chb_EnableCnCDDraw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(471, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video options";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtb_MaxFPS
            // 
            this.txtb_MaxFPS.Location = new System.Drawing.Point(373, 308);
            this.txtb_MaxFPS.Name = "txtb_MaxFPS";
            this.txtb_MaxFPS.Size = new System.Drawing.Size(33, 20);
            this.txtb_MaxFPS.TabIndex = 87;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 311);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(150, 13);
            this.label14.TabIndex = 86;
            this.label14.Text = "Max FPS  (slows scroll speed):";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radiob_RendererOpenGL);
            this.panel3.Controls.Add(this.radiob_RendererGDI);
            this.panel3.Location = new System.Drawing.Point(5, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 35);
            this.panel3.TabIndex = 85;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // radiob_RendererOpenGL
            // 
            this.radiob_RendererOpenGL.AutoSize = true;
            this.radiob_RendererOpenGL.Location = new System.Drawing.Point(53, 3);
            this.radiob_RendererOpenGL.Name = "radiob_RendererOpenGL";
            this.radiob_RendererOpenGL.Size = new System.Drawing.Size(65, 17);
            this.radiob_RendererOpenGL.TabIndex = 87;
            this.radiob_RendererOpenGL.TabStop = true;
            this.radiob_RendererOpenGL.Text = "OpenGL";
            this.radiob_RendererOpenGL.UseVisualStyleBackColor = true;
            // 
            // radiob_RendererGDI
            // 
            this.radiob_RendererGDI.AutoSize = true;
            this.radiob_RendererGDI.Location = new System.Drawing.Point(3, 3);
            this.radiob_RendererGDI.Name = "radiob_RendererGDI";
            this.radiob_RendererGDI.Size = new System.Drawing.Size(44, 17);
            this.radiob_RendererGDI.TabIndex = 86;
            this.radiob_RendererGDI.TabStop = true;
            this.radiob_RendererGDI.Text = "GDI";
            this.radiob_RendererGDI.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtb_resoCustomHeight);
            this.panel2.Controls.Add(this.radiob_reso640x400);
            this.panel2.Controls.Add(this.txtb_resoCustomWidth);
            this.panel2.Controls.Add(this.radiob_reso640x480);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.radiob_reso800x600);
            this.panel2.Controls.Add(this.radiob_resoCustom);
            this.panel2.Controls.Add(this.radiob_reso1024x768);
            this.panel2.Location = new System.Drawing.Point(3, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 94);
            this.panel2.TabIndex = 84;
            // 
            // txtb_resoCustomHeight
            // 
            this.txtb_resoCustomHeight.Location = new System.Drawing.Point(105, 73);
            this.txtb_resoCustomHeight.Name = "txtb_resoCustomHeight";
            this.txtb_resoCustomHeight.Size = new System.Drawing.Size(51, 20);
            this.txtb_resoCustomHeight.TabIndex = 92;
            this.txtb_resoCustomHeight.TextChanged += new System.EventHandler(this.txtb_resoCustomHeight_TextChanged);
            // 
            // radiob_reso640x400
            // 
            this.radiob_reso640x400.AutoSize = true;
            this.radiob_reso640x400.Location = new System.Drawing.Point(7, 4);
            this.radiob_reso640x400.Name = "radiob_reso640x400";
            this.radiob_reso640x400.Size = new System.Drawing.Size(66, 17);
            this.radiob_reso640x400.TabIndex = 85;
            this.radiob_reso640x400.TabStop = true;
            this.radiob_reso640x400.Text = "640x400";
            this.radiob_reso640x400.UseVisualStyleBackColor = true;
            this.radiob_reso640x400.CheckedChanged += new System.EventHandler(this.radiob_reso640x400_CheckedChanged_1);
            // 
            // txtb_resoCustomWidth
            // 
            this.txtb_resoCustomWidth.Location = new System.Drawing.Point(32, 73);
            this.txtb_resoCustomWidth.Name = "txtb_resoCustomWidth";
            this.txtb_resoCustomWidth.Size = new System.Drawing.Size(51, 20);
            this.txtb_resoCustomWidth.TabIndex = 91;
            this.txtb_resoCustomWidth.TextChanged += new System.EventHandler(this.txtb_resoCustomWidth_TextChanged);
            // 
            // radiob_reso640x480
            // 
            this.radiob_reso640x480.AutoSize = true;
            this.radiob_reso640x480.Location = new System.Drawing.Point(79, 4);
            this.radiob_reso640x480.Name = "radiob_reso640x480";
            this.radiob_reso640x480.Size = new System.Drawing.Size(66, 17);
            this.radiob_reso640x480.TabIndex = 86;
            this.radiob_reso640x480.TabStop = true;
            this.radiob_reso640x480.Text = "640x480";
            this.radiob_reso640x480.UseVisualStyleBackColor = true;
            this.radiob_reso640x480.CheckedChanged += new System.EventHandler(this.radiob_reso640x480_CheckedChanged_1);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(89, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(12, 13);
            this.label17.TabIndex = 90;
            this.label17.Text = "x";
            // 
            // radiob_reso800x600
            // 
            this.radiob_reso800x600.AutoSize = true;
            this.radiob_reso800x600.Location = new System.Drawing.Point(7, 27);
            this.radiob_reso800x600.Name = "radiob_reso800x600";
            this.radiob_reso800x600.Size = new System.Drawing.Size(66, 17);
            this.radiob_reso800x600.TabIndex = 87;
            this.radiob_reso800x600.TabStop = true;
            this.radiob_reso800x600.Text = "800x600";
            this.radiob_reso800x600.UseVisualStyleBackColor = true;
            this.radiob_reso800x600.CheckedChanged += new System.EventHandler(this.radiob_reso800x600_CheckedChanged_1);
            // 
            // radiob_resoCustom
            // 
            this.radiob_resoCustom.AutoSize = true;
            this.radiob_resoCustom.Location = new System.Drawing.Point(7, 50);
            this.radiob_resoCustom.Name = "radiob_resoCustom";
            this.radiob_resoCustom.Size = new System.Drawing.Size(63, 17);
            this.radiob_resoCustom.TabIndex = 89;
            this.radiob_resoCustom.TabStop = true;
            this.radiob_resoCustom.Text = "Custom:";
            this.radiob_resoCustom.UseVisualStyleBackColor = true;
            this.radiob_resoCustom.CheckedChanged += new System.EventHandler(this.radiob_resoCustom_CheckedChanged_1);
            // 
            // radiob_reso1024x768
            // 
            this.radiob_reso1024x768.AutoSize = true;
            this.radiob_reso1024x768.Location = new System.Drawing.Point(79, 27);
            this.radiob_reso1024x768.Name = "radiob_reso1024x768";
            this.radiob_reso1024x768.Size = new System.Drawing.Size(72, 17);
            this.radiob_reso1024x768.TabIndex = 88;
            this.radiob_reso1024x768.TabStop = true;
            this.radiob_reso1024x768.Text = "1024x768";
            this.radiob_reso1024x768.UseVisualStyleBackColor = true;
            this.radiob_reso1024x768.CheckedChanged += new System.EventHandler(this.radiob_reso1024x768_CheckedChanged_1);
            // 
            // but_DetectReso
            // 
            this.but_DetectReso.Location = new System.Drawing.Point(43, 146);
            this.but_DetectReso.Name = "but_DetectReso";
            this.but_DetectReso.Size = new System.Drawing.Size(104, 23);
            this.but_DetectReso.TabIndex = 83;
            this.but_DetectReso.Text = "Detect resolution";
            this.but_DetectReso.UseVisualStyleBackColor = true;
            this.but_DetectReso.Click += new System.EventHandler(this.but_DetectReso_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(238, 157);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(149, 13);
            this.label34.TabIndex = 82;
            this.label34.Text = "Use letter- or windowboxing to";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(238, 170);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(126, 13);
            this.label35.TabIndex = 81;
            this.label35.Text = "make a best fit (GDI only)";
            // 
            // chb_UseWindowBoxing
            // 
            this.chb_UseWindowBoxing.AutoSize = true;
            this.chb_UseWindowBoxing.Location = new System.Drawing.Point(220, 164);
            this.chb_UseWindowBoxing.Name = "chb_UseWindowBoxing";
            this.chb_UseWindowBoxing.Size = new System.Drawing.Size(15, 14);
            this.chb_UseWindowBoxing.TabIndex = 80;
            this.chb_UseWindowBoxing.UseVisualStyleBackColor = true;
            // 
            // chb_ShowWindowedBorder
            // 
            this.chb_ShowWindowedBorder.AutoSize = true;
            this.chb_ShowWindowedBorder.Location = new System.Drawing.Point(220, 125);
            this.chb_ShowWindowedBorder.Name = "chb_ShowWindowedBorder";
            this.chb_ShowWindowedBorder.Size = new System.Drawing.Size(216, 17);
            this.chb_ShowWindowedBorder.TabIndex = 79;
            this.chb_ShowWindowedBorder.Text = "Show window border in windowed mode";
            this.chb_ShowWindowedBorder.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(217, 333);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 13);
            this.label33.TabIndex = 78;
            this.label33.Text = "Bits per pixels:";
            // 
            // cmbox_BitsPerPixels
            // 
            this.cmbox_BitsPerPixels.FormattingEnabled = true;
            this.cmbox_BitsPerPixels.Items.AddRange(new object[] {
            "auto-detect",
            "16",
            "24",
            "32"});
            this.cmbox_BitsPerPixels.Location = new System.Drawing.Point(223, 354);
            this.cmbox_BitsPerPixels.Name = "cmbox_BitsPerPixels";
            this.cmbox_BitsPerPixels.Size = new System.Drawing.Size(153, 21);
            this.cmbox_BitsPerPixels.TabIndex = 77;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(238, 218);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(101, 13);
            this.label31.TabIndex = 76;
            this.label31.Text = "Enable mouse hack";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(238, 231);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(194, 13);
            this.label32.TabIndex = 75;
            this.label32.Text = "(enable if you experience mouse issues)";
            // 
            // chb_EnableMouseHack
            // 
            this.chb_EnableMouseHack.AutoSize = true;
            this.chb_EnableMouseHack.Location = new System.Drawing.Point(220, 225);
            this.chb_EnableMouseHack.Name = "chb_EnableMouseHack";
            this.chb_EnableMouseHack.Size = new System.Drawing.Size(15, 14);
            this.chb_EnableMouseHack.TabIndex = 74;
            this.chb_EnableMouseHack.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(238, 272);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(122, 13);
            this.label29.TabIndex = 73;
            this.label29.Text = "Force single CPU affinity";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(238, 285);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(203, 13);
            this.label30.TabIndex = 72;
            this.label30.Text = "(avoids crashes with RA, might be slower)";
            // 
            // chb_ForceSingleCPU
            // 
            this.chb_ForceSingleCPU.AutoSize = true;
            this.chb_ForceSingleCPU.Location = new System.Drawing.Point(220, 279);
            this.chb_ForceSingleCPU.Name = "chb_ForceSingleCPU";
            this.chb_ForceSingleCPU.Size = new System.Drawing.Size(15, 14);
            this.chb_ForceSingleCPU.TabIndex = 71;
            this.chb_ForceSingleCPU.UseVisualStyleBackColor = true;
            // 
            // chb_EnableVSync
            // 
            this.chb_EnableVSync.AutoSize = true;
            this.chb_EnableVSync.Location = new System.Drawing.Point(220, 249);
            this.chb_EnableVSync.Name = "chb_EnableVSync";
            this.chb_EnableVSync.Size = new System.Drawing.Size(90, 17);
            this.chb_EnableVSync.TabIndex = 70;
            this.chb_EnableVSync.Text = "Enable vsync";
            this.chb_EnableVSync.UseVisualStyleBackColor = true;
            this.chb_EnableVSync.CheckedChanged += new System.EventHandler(this.checkBox20_CheckedChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(238, 188);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "Automatically adjust mouse";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(238, 201);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "sensitivity to resolution";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // chb_AutoAdjustMouse
            // 
            this.chb_AutoAdjustMouse.AutoSize = true;
            this.chb_AutoAdjustMouse.Location = new System.Drawing.Point(220, 195);
            this.chb_AutoAdjustMouse.Name = "chb_AutoAdjustMouse";
            this.chb_AutoAdjustMouse.Size = new System.Drawing.Size(15, 14);
            this.chb_AutoAdjustMouse.TabIndex = 63;
            this.chb_AutoAdjustMouse.UseVisualStyleBackColor = true;
            // 
            // chb_RunWindowed
            // 
            this.chb_RunWindowed.AutoSize = true;
            this.chb_RunWindowed.Location = new System.Drawing.Point(220, 105);
            this.chb_RunWindowed.Name = "chb_RunWindowed";
            this.chb_RunWindowed.Size = new System.Drawing.Size(137, 17);
            this.chb_RunWindowed.TabIndex = 62;
            this.chb_RunWindowed.Text = "Run in windowed mode";
            this.chb_RunWindowed.UseVisualStyleBackColor = true;
            // 
            // chb_AllowHardwareFilledBits
            // 
            this.chb_AllowHardwareFilledBits.AutoSize = true;
            this.chb_AllowHardwareFilledBits.Location = new System.Drawing.Point(220, 70);
            this.chb_AllowHardwareFilledBits.Name = "chb_AllowHardwareFilledBits";
            this.chb_AllowHardwareFilledBits.Size = new System.Drawing.Size(141, 17);
            this.chb_AllowHardwareFilledBits.TabIndex = 61;
            this.chb_AllowHardwareFilledBits.Text = "Allow hardware filled bits";
            this.chb_AllowHardwareFilledBits.UseVisualStyleBackColor = true;
            // 
            // chb_BackBufferVideoMemory
            // 
            this.chb_BackBufferVideoMemory.AutoSize = true;
            this.chb_BackBufferVideoMemory.Location = new System.Drawing.Point(220, 52);
            this.chb_BackBufferVideoMemory.Name = "chb_BackBufferVideoMemory";
            this.chb_BackBufferVideoMemory.Size = new System.Drawing.Size(160, 17);
            this.chb_BackBufferVideoMemory.TabIndex = 60;
            this.chb_BackBufferVideoMemory.Text = "Back buffer in video memory";
            this.chb_BackBufferVideoMemory.UseVisualStyleBackColor = true;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(10, 339);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(80, 13);
            this.label24.TabIndex = 57;
            this.label24.Text = "Game renderer:";
            // 
            // txt_StretchingScaling
            // 
            this.txt_StretchingScaling.AutoSize = true;
            this.txt_StretchingScaling.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_StretchingScaling.Location = new System.Drawing.Point(6, 175);
            this.txt_StretchingScaling.Name = "txt_StretchingScaling";
            this.txt_StretchingScaling.Size = new System.Drawing.Size(96, 13);
            this.txt_StretchingScaling.TabIndex = 56;
            this.txt_StretchingScaling.Text = "Stretching/scaling:";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(6, 32);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 55;
            this.label22.Text = "Game resolution:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(7, 288);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(131, 13);
            this.label21.TabIndex = 54;
            this.label21.Text = "Scaling filter for stretching:";
            // 
            // cmbox_ScalingFilter
            // 
            this.cmbox_ScalingFilter.FormattingEnabled = true;
            this.cmbox_ScalingFilter.Items.AddRange(new object[] {
            "Nearest (sharp/pixelated)",
            "Linear (smooth/blurred)"});
            this.cmbox_ScalingFilter.Location = new System.Drawing.Point(13, 311);
            this.cmbox_ScalingFilter.Name = "cmbox_ScalingFilter";
            this.cmbox_ScalingFilter.Size = new System.Drawing.Size(153, 21);
            this.cmbox_ScalingFilter.TabIndex = 53;
            // 
            // chb_StretchCustom
            // 
            this.chb_StretchCustom.AutoSize = true;
            this.chb_StretchCustom.Location = new System.Drawing.Point(10, 233);
            this.chb_StretchCustom.Name = "chb_StretchCustom";
            this.chb_StretchCustom.Size = new System.Drawing.Size(160, 17);
            this.chb_StretchCustom.TabIndex = 52;
            this.chb_StretchCustom.Text = "Stretch to custom resolution:";
            this.chb_StretchCustom.UseVisualStyleBackColor = true;
            this.chb_StretchCustom.CheckedChanged += new System.EventHandler(this.chb_StretchCustom_CheckedChanged);
            // 
            // txtb_StretchCustomHeight
            // 
            this.txtb_StretchCustomHeight.Location = new System.Drawing.Point(108, 254);
            this.txtb_StretchCustomHeight.Name = "txtb_StretchCustomHeight";
            this.txtb_StretchCustomHeight.Size = new System.Drawing.Size(51, 20);
            this.txtb_StretchCustomHeight.TabIndex = 51;
            // 
            // txtb_StretchCustomWidth
            // 
            this.txtb_StretchCustomWidth.Location = new System.Drawing.Point(35, 254);
            this.txtb_StretchCustomWidth.Name = "txtb_StretchCustomWidth";
            this.txtb_StretchCustomWidth.Size = new System.Drawing.Size(51, 20);
            this.txtb_StretchCustomWidth.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(92, 256);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(12, 13);
            this.label20.TabIndex = 49;
            this.label20.Text = "x";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(28, 197);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(138, 13);
            this.label18.TabIndex = 48;
            this.label18.Text = "Use original RA aspect ratio";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // txt_UseRAAspectRatio
            // 
            this.txt_UseRAAspectRatio.AutoSize = true;
            this.txt_UseRAAspectRatio.Location = new System.Drawing.Point(28, 210);
            this.txt_UseRAAspectRatio.Name = "txt_UseRAAspectRatio";
            this.txt_UseRAAspectRatio.Size = new System.Drawing.Size(35, 13);
            this.txt_UseRAAspectRatio.TabIndex = 47;
            this.txt_UseRAAspectRatio.Text = "blabla";
            this.txt_UseRAAspectRatio.Click += new System.EventHandler(this.label19_Click);
            // 
            // chb_UseRAAspectRatio
            // 
            this.chb_UseRAAspectRatio.AutoSize = true;
            this.chb_UseRAAspectRatio.Location = new System.Drawing.Point(10, 204);
            this.chb_UseRAAspectRatio.Name = "chb_UseRAAspectRatio";
            this.chb_UseRAAspectRatio.Size = new System.Drawing.Size(15, 14);
            this.chb_UseRAAspectRatio.TabIndex = 46;
            this.chb_UseRAAspectRatio.UseVisualStyleBackColor = true;
            this.chb_UseRAAspectRatio.CheckedChanged += new System.EventHandler(this.chb_UseRAAspectRatio_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Location = new System.Drawing.Point(205, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 347);
            this.panel1.TabIndex = 44;
            // 
            // chb_EnableCnCDDraw
            // 
            this.chb_EnableCnCDDraw.AutoSize = true;
            this.chb_EnableCnCDDraw.Location = new System.Drawing.Point(9, 9);
            this.chb_EnableCnCDDraw.Name = "chb_EnableCnCDDraw";
            this.chb_EnableCnCDDraw.Size = new System.Drawing.Size(238, 17);
            this.chb_EnableCnCDDraw.TabIndex = 0;
            this.chb_EnableCnCDDraw.Text = "Use CnC-DDraw (enables advanced options)";
            this.chb_EnableCnCDDraw.UseVisualStyleBackColor = true;
            this.chb_EnableCnCDDraw.CheckedChanged += new System.EventHandler(this.chb_EnableCnCDDraw_CheckedChanged);
            // 
            // Form1
            // 
            this.AcceptButton = this.but_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_Cancel;
            this.ClientSize = new System.Drawing.Size(506, 465);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Red Alert 95 Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_MusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_GameSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ScrollRate)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

 /*       private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cncnet.org");
        }

        private void button3_Click(System.Object sender, System.EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cncnet.exe";
            process.StartInfo.Arguments = "-CFG";
            process.StartInfo.UseShellExecute = false;
            process.Start();
        } */

        #endregion

        private System.Windows.Forms.Button but_Cancel;
        private System.Windows.Forms.Button but_ok;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button but_RunCnCNetSetup;
        private System.Windows.Forms.LinkLabel link_CnCNetSite;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbox_Color;
        private System.Windows.Forms.ComboBox cmbox_Side;
        private System.Windows.Forms.TextBox txtb_Handle;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_UseLanPatch;
        private System.Windows.Forms.CheckBox chb_EnableSmallInfantry;
        private System.Windows.Forms.CheckBox chb_PlayIntro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Slider_MusicVolume;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar slider_SoundVolume;
        private System.Windows.Forms.CheckBox chb_RepeatMusic;
        private System.Windows.Forms.CheckBox chb_ShuffleMusic;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar slider_GameSpeed;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar slider_ScrollRate;
        private System.Windows.Forms.CheckBox chb_PaletteScroll;
        private System.Windows.Forms.CheckBox chb_Autoscroll;
        private System.Windows.Forms.CheckBox chb_EnableAftermath;
        private System.Windows.Forms.CheckBox chb_EnableCounterstrike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Label chb_ForceAfermath;
        private System.Windows.Forms.CheckBox chb_ForceAftermathOnline;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox chb_EnableCnCDDraw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txt_UseRAAspectRatio;
        private System.Windows.Forms.CheckBox chb_UseRAAspectRatio;
        private System.Windows.Forms.CheckBox chb_StretchCustom;
        private System.Windows.Forms.TextBox txtb_StretchCustomHeight;
        private System.Windows.Forms.TextBox txtb_StretchCustomWidth;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txt_StretchingScaling;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbox_ScalingFilter;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chb_AutoAdjustMouse;
        private System.Windows.Forms.CheckBox chb_RunWindowed;
        private System.Windows.Forms.CheckBox chb_AllowHardwareFilledBits;
        private System.Windows.Forms.CheckBox chb_BackBufferVideoMemory;
        private System.Windows.Forms.CheckBox chb_EnableVSync;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox chb_EnableMouseHack;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox chb_ForceSingleCPU;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbox_BitsPerPixels;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox chb_UseWindowBoxing;
        private System.Windows.Forms.CheckBox chb_ShowWindowedBorder;
        private System.Windows.Forms.Button but_DetectReso;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtb_resoCustomHeight;
        private System.Windows.Forms.RadioButton radiob_reso640x400;
        private System.Windows.Forms.TextBox txtb_resoCustomWidth;
        private System.Windows.Forms.RadioButton radiob_reso640x480;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radiob_reso800x600;
        private System.Windows.Forms.RadioButton radiob_resoCustom;
        private System.Windows.Forms.RadioButton radiob_reso1024x768;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radiob_RendererOpenGL;
        private System.Windows.Forms.RadioButton radiob_RendererGDI;
        private System.Windows.Forms.TextBox txtb_MaxFPS;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox chb_StandaloneExpanionMaps;
        private System.Windows.Forms.CheckBox checkBox1;

    }
}

