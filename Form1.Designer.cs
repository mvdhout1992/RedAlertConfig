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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.but_Cancel = new System.Windows.Forms.Button();
            this.but_ok = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.But_UseProSetup = new System.Windows.Forms.Button();
            this.but_ResetDefaults = new System.Windows.Forms.Button();
            this.but_ClearSelectedKey = new System.Windows.Forms.Button();
            this.grid_HotKeyEditor = new System.Windows.Forms.DataGridView();
            this.ColumnHotkeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHotkeyValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label59 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.chb_DisplayAftermathMaps = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.chb_DisplayCounterstrikeMaps = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.chb_DisplayOriginalMaps = new System.Windows.Forms.CheckBox();
            this.cmbox_AIDifficulty = new System.Windows.Forms.ComboBox();
            this.cmbox_AIPlayers = new System.Windows.Forms.ComboBox();
            this.cmbox_TechLevel = new System.Windows.Forms.ComboBox();
            this.cmbox_UnitCount = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.chb_Crates = new System.Windows.Forms.CheckBox();
            this.label50 = new System.Windows.Forms.Label();
            this.chb_OreRegenerates = new System.Windows.Forms.CheckBox();
            this.labelderp = new System.Windows.Forms.Label();
            this.chb_Bases = new System.Windows.Forms.CheckBox();
            this.label49 = new System.Windows.Forms.Label();
            this.chb_CaptureTheFlag = new System.Windows.Forms.CheckBox();
            this.label44 = new System.Windows.Forms.Label();
            this.chb_ShroudRegrows = new System.Windows.Forms.CheckBox();
            this.textb_Credits = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label100 = new System.Windows.Forms.Label();
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.chb_VideoStretching = new System.Windows.Forms.CheckBox();
            this.txtb_MaxFPS = new System.Windows.Forms.TextBox();
            this.txtb_StretchCustomHeight = new System.Windows.Forms.TextBox();
            this.txtb_StretchCustomWidth = new System.Windows.Forms.TextBox();
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
            this.label20 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_UseRAAspectRatio = new System.Windows.Forms.Label();
            this.chb_UseRAAspectRatio = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chb_EnableCnCDDraw = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.chb_NoCD = new System.Windows.Forms.CheckBox();
            this.cmbox_GameLanguage = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.chb_DeinterlaceVideos = new System.Windows.Forms.CheckBox();
            this.but_ResetVisualOptions = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.slider_Contrast = new System.Windows.Forms.TrackBar();
            this.label28 = new System.Windows.Forms.Label();
            this.slider_Tint = new System.Windows.Forms.TrackBar();
            this.label37 = new System.Windows.Forms.Label();
            this.slider_Color = new System.Windows.Forms.TrackBar();
            this.label23 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.slider_Brightness = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chb_UseLanPatch = new System.Windows.Forms.CheckBox();
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
            this.chb_EnableAftermath = new System.Windows.Forms.CheckBox();
            this.chb_EnableCounterstrike = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.chb_RemapCameoIcons = new System.Windows.Forms.CheckBox();
            this.chb_UseDOSInterfaceMod = new System.Windows.Forms.CheckBox();
            this.label30 = new System.Windows.Forms.Label();
            this.chb_EnableSmallInfantry = new System.Windows.Forms.CheckBox();
            this.chb_UseBetaGunboat = new System.Windows.Forms.CheckBox();
            this.chb_UseBetaDestroyer = new System.Windows.Forms.CheckBox();
            this.chb_UseBetaCruiser = new System.Windows.Forms.CheckBox();
            this.chb_UseBetaSubmarine = new System.Windows.Forms.CheckBox();
            this.chb_ForceAMUnitsInMissions = new System.Windows.Forms.CheckBox();
            this.chb_GenerateMemoryDump = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.chb_ShowAllMusic = new System.Windows.Forms.CheckBox();
            this.chb_UseBetaTeslaTank = new System.Windows.Forms.CheckBox();
            this.chb_UseAlternativeRifleSound = new System.Windows.Forms.CheckBox();
            this.chb_UseGrenadeThrowingSound = new System.Windows.Forms.CheckBox();
            this.chb_SkipScoreScreen = new System.Windows.Forms.CheckBox();
            this.chb_MouseWheelScrolling = new System.Windows.Forms.CheckBox();
            this.chb_RandomStartingSong = new System.Windows.Forms.CheckBox();
            this.label31 = new System.Windows.Forms.Label();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_HotKeyEditor)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Tint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Color)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_MusicVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SoundVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_GameSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ScrollRate)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // but_Cancel
            // 
            this.but_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.but_Cancel.Location = new System.Drawing.Point(389, 455);
            this.but_Cancel.Name = "but_Cancel";
            this.but_Cancel.Size = new System.Drawing.Size(75, 23);
            this.but_Cancel.TabIndex = 2;
            this.but_Cancel.Text = "Cancel";
            this.but_Cancel.UseVisualStyleBackColor = true;
            this.but_Cancel.Click += new System.EventHandler(this.but_Cancel_Click);
            // 
            // but_ok
            // 
            this.but_ok.Location = new System.Drawing.Point(293, 455);
            this.but_ok.Name = "but_ok";
            this.but_ok.Size = new System.Drawing.Size(75, 23);
            this.but_ok.TabIndex = 3;
            this.but_ok.Text = "OK";
            this.but_ok.UseVisualStyleBackColor = true;
            this.but_ok.Click += new System.EventHandler(this.but_ok_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.But_UseProSetup);
            this.tabPage4.Controls.Add(this.but_ResetDefaults);
            this.tabPage4.Controls.Add(this.but_ClearSelectedKey);
            this.tabPage4.Controls.Add(this.grid_HotKeyEditor);
            this.tabPage4.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(441, 412);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Hotkey editor";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.tabPage4.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.tabPage4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            this.tabPage4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            // 
            // But_UseProSetup
            // 
            this.But_UseProSetup.Location = new System.Drawing.Point(274, 107);
            this.But_UseProSetup.Name = "But_UseProSetup";
            this.But_UseProSetup.Size = new System.Drawing.Size(139, 23);
            this.But_UseProSetup.TabIndex = 3;
            this.But_UseProSetup.Text = "Use pro configuration";
            this.But_UseProSetup.UseVisualStyleBackColor = true;
            this.But_UseProSetup.Click += new System.EventHandler(this.But_UseProSetup_Click);
            // 
            // but_ResetDefaults
            // 
            this.but_ResetDefaults.Location = new System.Drawing.Point(274, 136);
            this.but_ResetDefaults.Name = "but_ResetDefaults";
            this.but_ResetDefaults.Size = new System.Drawing.Size(139, 23);
            this.but_ResetDefaults.TabIndex = 2;
            this.but_ResetDefaults.Text = "Reset to defaults";
            this.but_ResetDefaults.UseVisualStyleBackColor = true;
            this.but_ResetDefaults.Click += new System.EventHandler(this.but_ResetDefaults_Click);
            // 
            // but_ClearSelectedKey
            // 
            this.but_ClearSelectedKey.Location = new System.Drawing.Point(274, 49);
            this.but_ClearSelectedKey.Name = "but_ClearSelectedKey";
            this.but_ClearSelectedKey.Size = new System.Drawing.Size(139, 23);
            this.but_ClearSelectedKey.TabIndex = 1;
            this.but_ClearSelectedKey.Text = "Clear selected key";
            this.but_ClearSelectedKey.UseVisualStyleBackColor = true;
            this.but_ClearSelectedKey.Click += new System.EventHandler(this.but_ClearSelectedKey_Click);
            // 
            // grid_HotKeyEditor
            // 
            this.grid_HotKeyEditor.AllowUserToAddRows = false;
            this.grid_HotKeyEditor.AllowUserToDeleteRows = false;
            this.grid_HotKeyEditor.AllowUserToResizeRows = false;
            this.grid_HotKeyEditor.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.grid_HotKeyEditor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_HotKeyEditor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnHotkeyName,
            this.ColumnHotkeyValue});
            this.grid_HotKeyEditor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.grid_HotKeyEditor.Location = new System.Drawing.Point(16, 17);
            this.grid_HotKeyEditor.Name = "grid_HotKeyEditor";
            this.grid_HotKeyEditor.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid_HotKeyEditor.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.grid_HotKeyEditor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grid_HotKeyEditor.Size = new System.Drawing.Size(226, 353);
            this.grid_HotKeyEditor.TabIndex = 0;
            this.grid_HotKeyEditor.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.Hotkey_Editor_Editing_Control_Showing);
            this.grid_HotKeyEditor.DoubleClick += new System.EventHandler(this.OnMouseClick);
            this.grid_HotKeyEditor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseClick);
            // 
            // ColumnHotkeyName
            // 
            this.ColumnHotkeyName.Frozen = true;
            this.ColumnHotkeyName.HeaderText = "Hotkey name";
            this.ColumnHotkeyName.Name = "ColumnHotkeyName";
            this.ColumnHotkeyName.ReadOnly = true;
            this.ColumnHotkeyName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnHotkeyValue
            // 
            this.ColumnHotkeyValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnHotkeyValue.HeaderText = "Assigned key";
            this.ColumnHotkeyValue.Name = "ColumnHotkeyValue";
            this.ColumnHotkeyValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label59);
            this.tabPage3.Controls.Add(this.label58);
            this.tabPage3.Controls.Add(this.chb_DisplayAftermathMaps);
            this.tabPage3.Controls.Add(this.label57);
            this.tabPage3.Controls.Add(this.chb_DisplayCounterstrikeMaps);
            this.tabPage3.Controls.Add(this.label56);
            this.tabPage3.Controls.Add(this.chb_DisplayOriginalMaps);
            this.tabPage3.Controls.Add(this.cmbox_AIDifficulty);
            this.tabPage3.Controls.Add(this.cmbox_AIPlayers);
            this.tabPage3.Controls.Add(this.cmbox_TechLevel);
            this.tabPage3.Controls.Add(this.cmbox_UnitCount);
            this.tabPage3.Controls.Add(this.label54);
            this.tabPage3.Controls.Add(this.label55);
            this.tabPage3.Controls.Add(this.label53);
            this.tabPage3.Controls.Add(this.label51);
            this.tabPage3.Controls.Add(this.label52);
            this.tabPage3.Controls.Add(this.chb_Crates);
            this.tabPage3.Controls.Add(this.label50);
            this.tabPage3.Controls.Add(this.chb_OreRegenerates);
            this.tabPage3.Controls.Add(this.labelderp);
            this.tabPage3.Controls.Add(this.chb_Bases);
            this.tabPage3.Controls.Add(this.label49);
            this.tabPage3.Controls.Add(this.chb_CaptureTheFlag);
            this.tabPage3.Controls.Add(this.label44);
            this.tabPage3.Controls.Add(this.chb_ShroudRegrows);
            this.tabPage3.Controls.Add(this.textb_Credits);
            this.tabPage3.Controls.Add(this.label42);
            this.tabPage3.Controls.Add(this.label36);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label100);
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
            this.tabPage3.Size = new System.Drawing.Size(441, 412);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Multiplayer";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label59.Location = new System.Drawing.Point(27, 316);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(387, 13);
            this.label59.TabIndex = 77;
            this.label59.Text = "enabled or you can\'t join games hosted by other people and they can\'t join yours." +
                "";
            this.label59.Visible = false;
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Location = new System.Drawing.Point(302, 179);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(117, 13);
            this.label58.TabIndex = 76;
            this.label58.Text = "Display Aftermath maps";
            // 
            // chb_DisplayAftermathMaps
            // 
            this.chb_DisplayAftermathMaps.AutoSize = true;
            this.chb_DisplayAftermathMaps.Location = new System.Drawing.Point(285, 179);
            this.chb_DisplayAftermathMaps.Name = "chb_DisplayAftermathMaps";
            this.chb_DisplayAftermathMaps.Size = new System.Drawing.Size(15, 14);
            this.chb_DisplayAftermathMaps.TabIndex = 75;
            this.chb_DisplayAftermathMaps.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(302, 160);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(134, 13);
            this.label57.TabIndex = 74;
            this.label57.Text = "Display Counterstrike maps";
            // 
            // chb_DisplayCounterstrikeMaps
            // 
            this.chb_DisplayCounterstrikeMaps.AutoSize = true;
            this.chb_DisplayCounterstrikeMaps.Location = new System.Drawing.Point(285, 160);
            this.chb_DisplayCounterstrikeMaps.Name = "chb_DisplayCounterstrikeMaps";
            this.chb_DisplayCounterstrikeMaps.Size = new System.Drawing.Size(15, 14);
            this.chb_DisplayCounterstrikeMaps.TabIndex = 73;
            this.chb_DisplayCounterstrikeMaps.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(302, 140);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(134, 13);
            this.label56.TabIndex = 72;
            this.label56.Text = "Display original game maps";
            // 
            // chb_DisplayOriginalMaps
            // 
            this.chb_DisplayOriginalMaps.AutoSize = true;
            this.chb_DisplayOriginalMaps.Location = new System.Drawing.Point(285, 140);
            this.chb_DisplayOriginalMaps.Name = "chb_DisplayOriginalMaps";
            this.chb_DisplayOriginalMaps.Size = new System.Drawing.Size(15, 14);
            this.chb_DisplayOriginalMaps.TabIndex = 71;
            this.chb_DisplayOriginalMaps.UseVisualStyleBackColor = true;
            // 
            // cmbox_AIDifficulty
            // 
            this.cmbox_AIDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_AIDifficulty.FormattingEnabled = true;
            this.cmbox_AIDifficulty.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.cmbox_AIDifficulty.Location = new System.Drawing.Point(198, 167);
            this.cmbox_AIDifficulty.Name = "cmbox_AIDifficulty";
            this.cmbox_AIDifficulty.Size = new System.Drawing.Size(67, 21);
            this.cmbox_AIDifficulty.TabIndex = 70;
            // 
            // cmbox_AIPlayers
            // 
            this.cmbox_AIPlayers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_AIPlayers.FormattingEnabled = true;
            this.cmbox_AIPlayers.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.cmbox_AIPlayers.Location = new System.Drawing.Point(198, 139);
            this.cmbox_AIPlayers.Name = "cmbox_AIPlayers";
            this.cmbox_AIPlayers.Size = new System.Drawing.Size(67, 21);
            this.cmbox_AIPlayers.TabIndex = 69;
            // 
            // cmbox_TechLevel
            // 
            this.cmbox_TechLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_TechLevel.FormattingEnabled = true;
            this.cmbox_TechLevel.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmbox_TechLevel.Location = new System.Drawing.Point(92, 167);
            this.cmbox_TechLevel.Name = "cmbox_TechLevel";
            this.cmbox_TechLevel.Size = new System.Drawing.Size(38, 21);
            this.cmbox_TechLevel.TabIndex = 68;
            // 
            // cmbox_UnitCount
            // 
            this.cmbox_UnitCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_UnitCount.FormattingEnabled = true;
            this.cmbox_UnitCount.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.cmbox_UnitCount.Location = new System.Drawing.Point(92, 139);
            this.cmbox_UnitCount.Name = "cmbox_UnitCount";
            this.cmbox_UnitCount.Size = new System.Drawing.Size(38, 21);
            this.cmbox_UnitCount.TabIndex = 67;
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(136, 170);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(61, 13);
            this.label54.TabIndex = 66;
            this.label54.Text = "AI difficulty:";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(136, 141);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(56, 13);
            this.label55.TabIndex = 65;
            this.label55.Text = "AI players:";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(27, 170);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(60, 13);
            this.label53.TabIndex = 64;
            this.label53.Text = "Tech level:";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(27, 141);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(59, 13);
            this.label51.TabIndex = 63;
            this.label51.Text = "Unit count:";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(302, 72);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(37, 13);
            this.label52.TabIndex = 62;
            this.label52.Text = "Crates";
            // 
            // chb_Crates
            // 
            this.chb_Crates.AutoSize = true;
            this.chb_Crates.Location = new System.Drawing.Point(285, 72);
            this.chb_Crates.Name = "chb_Crates";
            this.chb_Crates.Size = new System.Drawing.Size(15, 14);
            this.chb_Crates.TabIndex = 61;
            this.chb_Crates.UseVisualStyleBackColor = true;
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(302, 52);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(83, 13);
            this.label50.TabIndex = 60;
            this.label50.Text = "Ore regenerates";
            // 
            // chb_OreRegenerates
            // 
            this.chb_OreRegenerates.AutoSize = true;
            this.chb_OreRegenerates.Location = new System.Drawing.Point(285, 52);
            this.chb_OreRegenerates.Name = "chb_OreRegenerates";
            this.chb_OreRegenerates.Size = new System.Drawing.Size(15, 14);
            this.chb_OreRegenerates.TabIndex = 59;
            this.chb_OreRegenerates.UseVisualStyleBackColor = true;
            // 
            // labelderp
            // 
            this.labelderp.AutoSize = true;
            this.labelderp.Location = new System.Drawing.Point(301, 32);
            this.labelderp.Name = "labelderp";
            this.labelderp.Size = new System.Drawing.Size(36, 13);
            this.labelderp.TabIndex = 58;
            this.labelderp.Text = "Bases";
            // 
            // chb_Bases
            // 
            this.chb_Bases.AutoSize = true;
            this.chb_Bases.Location = new System.Drawing.Point(285, 32);
            this.chb_Bases.Name = "chb_Bases";
            this.chb_Bases.Size = new System.Drawing.Size(15, 14);
            this.chb_Bases.TabIndex = 57;
            this.chb_Bases.UseVisualStyleBackColor = true;
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(302, 112);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(82, 13);
            this.label49.TabIndex = 56;
            this.label49.Text = "Capture the flag";
            // 
            // chb_CaptureTheFlag
            // 
            this.chb_CaptureTheFlag.AutoSize = true;
            this.chb_CaptureTheFlag.Location = new System.Drawing.Point(285, 112);
            this.chb_CaptureTheFlag.Name = "chb_CaptureTheFlag";
            this.chb_CaptureTheFlag.Size = new System.Drawing.Size(15, 14);
            this.chb_CaptureTheFlag.TabIndex = 55;
            this.chb_CaptureTheFlag.UseVisualStyleBackColor = true;
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(301, 92);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(81, 13);
            this.label44.TabIndex = 54;
            this.label44.Text = "Shroud regrows";
            // 
            // chb_ShroudRegrows
            // 
            this.chb_ShroudRegrows.AutoSize = true;
            this.chb_ShroudRegrows.Location = new System.Drawing.Point(285, 92);
            this.chb_ShroudRegrows.Name = "chb_ShroudRegrows";
            this.chb_ShroudRegrows.Size = new System.Drawing.Size(15, 14);
            this.chb_ShroudRegrows.TabIndex = 53;
            this.chb_ShroudRegrows.UseVisualStyleBackColor = true;
            // 
            // textb_Credits
            // 
            this.textb_Credits.Location = new System.Drawing.Point(92, 112);
            this.textb_Credits.Name = "textb_Credits";
            this.textb_Credits.Size = new System.Drawing.Size(173, 20);
            this.textb_Credits.TabIndex = 52;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(27, 115);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(42, 13);
            this.label42.TabIndex = 51;
            this.label42.Text = "Credits:";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(160, 249);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(194, 13);
            this.label36.TabIndex = 47;
            this.label36.Text = "Open cncnet.exe to start playing online.";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label16.Location = new System.Drawing.Point(9, 280);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(36, 13);
            this.label16.TabIndex = 46;
            this.label16.Text = "Other:";
            this.label16.Visible = false;
            // 
            // label100
            // 
            this.label100.AutoSize = true;
            this.label100.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label100.Location = new System.Drawing.Point(27, 301);
            this.label100.Name = "label100";
            this.label100.Size = new System.Drawing.Size(383, 13);
            this.label100.TabIndex = 44;
            this.label100.Text = "NOTE: If you use the below options online other players also need to have them";
            this.label100.Visible = false;
            this.label100.Click += new System.EventHandler(this.label14_Click);
            // 
            // but_RunCnCNetSetup
            // 
            this.but_RunCnCNetSetup.Location = new System.Drawing.Point(32, 244);
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
            this.link_CnCNetSite.Location = new System.Drawing.Point(29, 222);
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
            this.label13.Location = new System.Drawing.Point(9, 202);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 13);
            this.label13.TabIndex = 40;
            this.label13.Text = "CnCNet options:";
            // 
            // cmbox_Color
            // 
            this.cmbox_Color.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_Color.FormattingEnabled = true;
            this.cmbox_Color.Items.AddRange(new object[] {
            "Yellow",
            "Blue",
            "Red",
            "Green",
            "Orange",
            "Grey",
            "Teal",
            "Brown"});
            this.cmbox_Color.Location = new System.Drawing.Point(92, 85);
            this.cmbox_Color.Name = "cmbox_Color";
            this.cmbox_Color.Size = new System.Drawing.Size(173, 21);
            this.cmbox_Color.TabIndex = 39;
            // 
            // cmbox_Side
            // 
            this.cmbox_Side.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_Side.FormattingEnabled = true;
            this.cmbox_Side.Items.AddRange(new object[] {
            "Russia",
            "England",
            "Ukraine",
            "Germany",
            "France",
            "Turkey",
            "Spain",
            "Greece"});
            this.cmbox_Side.Location = new System.Drawing.Point(92, 60);
            this.cmbox_Side.Name = "cmbox_Side";
            this.cmbox_Side.Size = new System.Drawing.Size(173, 21);
            this.cmbox_Side.TabIndex = 38;
            // 
            // txtb_Handle
            // 
            this.txtb_Handle.Location = new System.Drawing.Point(92, 35);
            this.txtb_Handle.Name = "txtb_Handle";
            this.txtb_Handle.Size = new System.Drawing.Size(173, 20);
            this.txtb_Handle.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(27, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Color:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 63);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(31, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Side:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 38);
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
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "Multiplayer defaults:";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.chb_VideoStretching);
            this.tabPage1.Controls.Add(this.txtb_MaxFPS);
            this.tabPage1.Controls.Add(this.txtb_StretchCustomHeight);
            this.tabPage1.Controls.Add(this.txtb_StretchCustomWidth);
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
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.label18);
            this.tabPage1.Controls.Add(this.txt_UseRAAspectRatio);
            this.tabPage1.Controls.Add(this.chb_UseRAAspectRatio);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.chb_EnableCnCDDraw);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(441, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Video options";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // chb_VideoStretching
            // 
            this.chb_VideoStretching.AutoSize = true;
            this.chb_VideoStretching.Location = new System.Drawing.Point(220, 153);
            this.chb_VideoStretching.Name = "chb_VideoStretching";
            this.chb_VideoStretching.Size = new System.Drawing.Size(220, 17);
            this.chb_VideoStretching.TabIndex = 88;
            this.chb_VideoStretching.Text = "Enable movies stretching (recommended)";
            this.chb_VideoStretching.UseVisualStyleBackColor = true;
            // 
            // txtb_MaxFPS
            // 
            this.txtb_MaxFPS.Location = new System.Drawing.Point(373, 242);
            this.txtb_MaxFPS.Name = "txtb_MaxFPS";
            this.txtb_MaxFPS.Size = new System.Drawing.Size(33, 20);
            this.txtb_MaxFPS.TabIndex = 87;
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(217, 242);
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
            this.radiob_RendererOpenGL.CheckedChanged += new System.EventHandler(this.radiob_RendererOpenGL_CheckedChanged);
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
            this.radiob_RendererGDI.CheckedChanged += new System.EventHandler(this.radiob_RendererGDI_CheckedChanged);
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
            this.label34.Location = new System.Drawing.Point(238, 173);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(149, 13);
            this.label34.TabIndex = 82;
            this.label34.Text = "Use letter- or windowboxing to";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(238, 186);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(76, 13);
            this.label35.TabIndex = 81;
            this.label35.Text = "make a best fit";
            // 
            // chb_UseWindowBoxing
            // 
            this.chb_UseWindowBoxing.AutoSize = true;
            this.chb_UseWindowBoxing.Location = new System.Drawing.Point(220, 180);
            this.chb_UseWindowBoxing.Name = "chb_UseWindowBoxing";
            this.chb_UseWindowBoxing.Size = new System.Drawing.Size(15, 14);
            this.chb_UseWindowBoxing.TabIndex = 80;
            this.chb_UseWindowBoxing.UseVisualStyleBackColor = true;
            // 
            // chb_ShowWindowedBorder
            // 
            this.chb_ShowWindowedBorder.AutoSize = true;
            this.chb_ShowWindowedBorder.Location = new System.Drawing.Point(220, 87);
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
            this.label33.Location = new System.Drawing.Point(217, 266);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(74, 13);
            this.label33.TabIndex = 78;
            this.label33.Text = "Bits per pixels:";
            // 
            // cmbox_BitsPerPixels
            // 
            this.cmbox_BitsPerPixels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_BitsPerPixels.FormattingEnabled = true;
            this.cmbox_BitsPerPixels.Items.AddRange(new object[] {
            "Auto-detect",
            "16",
            "24",
            "32"});
            this.cmbox_BitsPerPixels.Location = new System.Drawing.Point(223, 287);
            this.cmbox_BitsPerPixels.Name = "cmbox_BitsPerPixels";
            this.cmbox_BitsPerPixels.Size = new System.Drawing.Size(153, 21);
            this.cmbox_BitsPerPixels.TabIndex = 77;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(238, 204);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(134, 13);
            this.label25.TabIndex = 65;
            this.label25.Text = "Automatically adjust mouse";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(238, 217);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(112, 13);
            this.label26.TabIndex = 64;
            this.label26.Text = "sensitivity to resolution";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // chb_AutoAdjustMouse
            // 
            this.chb_AutoAdjustMouse.AutoSize = true;
            this.chb_AutoAdjustMouse.Location = new System.Drawing.Point(220, 211);
            this.chb_AutoAdjustMouse.Name = "chb_AutoAdjustMouse";
            this.chb_AutoAdjustMouse.Size = new System.Drawing.Size(15, 14);
            this.chb_AutoAdjustMouse.TabIndex = 63;
            this.chb_AutoAdjustMouse.UseVisualStyleBackColor = true;
            // 
            // chb_RunWindowed
            // 
            this.chb_RunWindowed.AutoSize = true;
            this.chb_RunWindowed.Location = new System.Drawing.Point(220, 107);
            this.chb_RunWindowed.Name = "chb_RunWindowed";
            this.chb_RunWindowed.Size = new System.Drawing.Size(137, 17);
            this.chb_RunWindowed.TabIndex = 62;
            this.chb_RunWindowed.Text = "Run in windowed mode";
            this.chb_RunWindowed.UseVisualStyleBackColor = true;
            // 
            // chb_AllowHardwareFilledBits
            // 
            this.chb_AllowHardwareFilledBits.AutoSize = true;
            this.chb_AllowHardwareFilledBits.Location = new System.Drawing.Point(220, 48);
            this.chb_AllowHardwareFilledBits.Name = "chb_AllowHardwareFilledBits";
            this.chb_AllowHardwareFilledBits.Size = new System.Drawing.Size(143, 17);
            this.chb_AllowHardwareFilledBits.TabIndex = 61;
            this.chb_AllowHardwareFilledBits.Text = "Allow hardware filled blits";
            this.chb_AllowHardwareFilledBits.UseVisualStyleBackColor = true;
            // 
            // chb_BackBufferVideoMemory
            // 
            this.chb_BackBufferVideoMemory.AutoSize = true;
            this.chb_BackBufferVideoMemory.Location = new System.Drawing.Point(220, 30);
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
            this.cmbox_ScalingFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
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
            this.panel1.Location = new System.Drawing.Point(205, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 380);
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.chb_NoCD);
            this.tabPage2.Controls.Add(this.cmbox_GameLanguage);
            this.tabPage2.Controls.Add(this.label60);
            this.tabPage2.Controls.Add(this.chb_DeinterlaceVideos);
            this.tabPage2.Controls.Add(this.but_ResetVisualOptions);
            this.tabPage2.Controls.Add(this.panel9);
            this.tabPage2.Controls.Add(this.panel8);
            this.tabPage2.Controls.Add(this.panel7);
            this.tabPage2.Controls.Add(this.panel6);
            this.tabPage2.Controls.Add(this.slider_Contrast);
            this.tabPage2.Controls.Add(this.label28);
            this.tabPage2.Controls.Add(this.slider_Tint);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.slider_Color);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label27);
            this.tabPage2.Controls.Add(this.slider_Brightness);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.panel5);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.chb_UseLanPatch);
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
            this.tabPage2.Controls.Add(this.chb_EnableAftermath);
            this.tabPage2.Controls.Add(this.chb_EnableCounterstrike);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(441, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Game options";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // chb_NoCD
            // 
            this.chb_NoCD.AutoSize = true;
            this.chb_NoCD.Location = new System.Drawing.Point(204, 73);
            this.chb_NoCD.Name = "chb_NoCD";
            this.chb_NoCD.Size = new System.Drawing.Size(99, 17);
            this.chb_NoCD.TabIndex = 58;
            this.chb_NoCD.Text = "No CD required";
            this.chb_NoCD.UseVisualStyleBackColor = true;
            // 
            // cmbox_GameLanguage
            // 
            this.cmbox_GameLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbox_GameLanguage.FormattingEnabled = true;
            this.cmbox_GameLanguage.Items.AddRange(new object[] {
            "English",
            "German",
            "German (Censored)",
            "German (Uncensored)",
            "French",
            "Spanish",
            "Russian"});
            this.cmbox_GameLanguage.Location = new System.Drawing.Point(117, 103);
            this.cmbox_GameLanguage.Name = "cmbox_GameLanguage";
            this.cmbox_GameLanguage.Size = new System.Drawing.Size(132, 21);
            this.cmbox_GameLanguage.TabIndex = 57;
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Location = new System.Drawing.Point(18, 106);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(85, 13);
            this.label60.TabIndex = 56;
            this.label60.Text = "Game language:";
            // 
            // chb_DeinterlaceVideos
            // 
            this.chb_DeinterlaceVideos.AutoSize = true;
            this.chb_DeinterlaceVideos.Location = new System.Drawing.Point(21, 73);
            this.chb_DeinterlaceVideos.Name = "chb_DeinterlaceVideos";
            this.chb_DeinterlaceVideos.Size = new System.Drawing.Size(114, 17);
            this.chb_DeinterlaceVideos.TabIndex = 54;
            this.chb_DeinterlaceVideos.Text = "Deinterlace videos";
            this.chb_DeinterlaceVideos.UseVisualStyleBackColor = true;
            // 
            // but_ResetVisualOptions
            // 
            this.but_ResetVisualOptions.Location = new System.Drawing.Point(369, 357);
            this.but_ResetVisualOptions.Name = "but_ResetVisualOptions";
            this.but_ResetVisualOptions.Size = new System.Drawing.Size(59, 23);
            this.but_ResetVisualOptions.TabIndex = 51;
            this.but_ResetVisualOptions.Text = "Reset";
            this.but_ResetVisualOptions.UseVisualStyleBackColor = true;
            this.but_ResetVisualOptions.Click += new System.EventHandler(this.but_ResetVisualOptions_Click);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.Location = new System.Drawing.Point(257, 396);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(102, 10);
            this.panel9.TabIndex = 50;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.Window;
            this.panel8.Location = new System.Drawing.Point(257, 364);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(102, 10);
            this.panel8.TabIndex = 49;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Location = new System.Drawing.Point(99, 364);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(102, 10);
            this.panel7.TabIndex = 48;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Window;
            this.panel6.Location = new System.Drawing.Point(99, 397);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(102, 10);
            this.panel6.TabIndex = 47;
            // 
            // slider_Contrast
            // 
            this.slider_Contrast.AutoSize = false;
            this.slider_Contrast.BackColor = System.Drawing.SystemColors.Window;
            this.slider_Contrast.LargeChange = 1;
            this.slider_Contrast.Location = new System.Drawing.Point(94, 375);
            this.slider_Contrast.Maximum = 1000;
            this.slider_Contrast.Name = "slider_Contrast";
            this.slider_Contrast.RightToLeftLayout = true;
            this.slider_Contrast.Size = new System.Drawing.Size(107, 27);
            this.slider_Contrast.SmallChange = 10;
            this.slider_Contrast.TabIndex = 46;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(207, 379);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(28, 13);
            this.label28.TabIndex = 45;
            this.label28.Text = "Tint:";
            // 
            // slider_Tint
            // 
            this.slider_Tint.AutoSize = false;
            this.slider_Tint.BackColor = System.Drawing.SystemColors.Window;
            this.slider_Tint.LargeChange = 1;
            this.slider_Tint.Location = new System.Drawing.Point(252, 375);
            this.slider_Tint.Maximum = 1000;
            this.slider_Tint.Name = "slider_Tint";
            this.slider_Tint.RightToLeftLayout = true;
            this.slider_Tint.Size = new System.Drawing.Size(107, 27);
            this.slider_Tint.SmallChange = 10;
            this.slider_Tint.TabIndex = 44;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(207, 346);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(34, 13);
            this.label37.TabIndex = 43;
            this.label37.Text = "Color:";
            // 
            // slider_Color
            // 
            this.slider_Color.AccessibleDescription = "";
            this.slider_Color.AutoSize = false;
            this.slider_Color.BackColor = System.Drawing.SystemColors.Window;
            this.slider_Color.LargeChange = 1;
            this.slider_Color.Location = new System.Drawing.Point(252, 343);
            this.slider_Color.Maximum = 1000;
            this.slider_Color.Name = "slider_Color";
            this.slider_Color.RightToLeftLayout = true;
            this.slider_Color.Size = new System.Drawing.Size(107, 27);
            this.slider_Color.SmallChange = 10;
            this.slider_Color.TabIndex = 42;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(18, 379);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(54, 13);
            this.label23.TabIndex = 39;
            this.label23.Text = "Constrast:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(18, 347);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 37;
            this.label27.Text = "Brightness:";
            // 
            // slider_Brightness
            // 
            this.slider_Brightness.AutoSize = false;
            this.slider_Brightness.BackColor = System.Drawing.SystemColors.Window;
            this.slider_Brightness.LargeChange = 1;
            this.slider_Brightness.Location = new System.Drawing.Point(94, 343);
            this.slider_Brightness.Maximum = 1000;
            this.slider_Brightness.Name = "slider_Brightness";
            this.slider_Brightness.RightToLeftLayout = true;
            this.slider_Brightness.Size = new System.Drawing.Size(107, 27);
            this.slider_Brightness.SmallChange = 10;
            this.slider_Brightness.TabIndex = 36;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 320);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Visual options:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.Window;
            this.panel5.Location = new System.Drawing.Point(117, 272);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(148, 10);
            this.panel5.TabIndex = 34;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Window;
            this.panel4.Location = new System.Drawing.Point(117, 310);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(148, 10);
            this.panel4.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(6, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "General:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(6, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Scrolling and speed:";
            // 
            // chb_UseLanPatch
            // 
            this.chb_UseLanPatch.AutoSize = true;
            this.chb_UseLanPatch.Location = new System.Drawing.Point(21, 27);
            this.chb_UseLanPatch.Name = "chb_UseLanPatch";
            this.chb_UseLanPatch.Size = new System.Drawing.Size(99, 17);
            this.chb_UseLanPatch.TabIndex = 29;
            this.chb_UseLanPatch.Text = "Use LAN patch";
            this.chb_UseLanPatch.UseVisualStyleBackColor = true;
            // 
            // chb_PlayIntro
            // 
            this.chb_PlayIntro.AutoSize = true;
            this.chb_PlayIntro.Location = new System.Drawing.Point(21, 50);
            this.chb_PlayIntro.Name = "chb_PlayIntro";
            this.chb_PlayIntro.Size = new System.Drawing.Size(117, 17);
            this.chb_PlayIntro.TabIndex = 27;
            this.chb_PlayIntro.Text = "Play intro cinematic";
            this.chb_PlayIntro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Music volume:";
            // 
            // Slider_MusicVolume
            // 
            this.Slider_MusicVolume.AutoSize = false;
            this.Slider_MusicVolume.BackColor = System.Drawing.SystemColors.Window;
            this.Slider_MusicVolume.LargeChange = 1;
            this.Slider_MusicVolume.Location = new System.Drawing.Point(112, 288);
            this.Slider_MusicVolume.Maximum = 1000;
            this.Slider_MusicVolume.Name = "Slider_MusicVolume";
            this.Slider_MusicVolume.RightToLeftLayout = true;
            this.Slider_MusicVolume.Size = new System.Drawing.Size(153, 28);
            this.Slider_MusicVolume.SmallChange = 10;
            this.Slider_MusicVolume.TabIndex = 25;
            this.Slider_MusicVolume.Value = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Sound volume:";
            // 
            // slider_SoundVolume
            // 
            this.slider_SoundVolume.AutoSize = false;
            this.slider_SoundVolume.BackColor = System.Drawing.SystemColors.Window;
            this.slider_SoundVolume.LargeChange = 1;
            this.slider_SoundVolume.Location = new System.Drawing.Point(112, 250);
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
            this.chb_RepeatMusic.Location = new System.Drawing.Point(284, 288);
            this.chb_RepeatMusic.Name = "chb_RepeatMusic";
            this.chb_RepeatMusic.Size = new System.Drawing.Size(91, 17);
            this.chb_RepeatMusic.TabIndex = 22;
            this.chb_RepeatMusic.Text = "Repeat music";
            this.chb_RepeatMusic.UseVisualStyleBackColor = true;
            // 
            // chb_ShuffleMusic
            // 
            this.chb_ShuffleMusic.AutoSize = true;
            this.chb_ShuffleMusic.Location = new System.Drawing.Point(284, 265);
            this.chb_ShuffleMusic.Name = "chb_ShuffleMusic";
            this.chb_ShuffleMusic.Size = new System.Drawing.Size(89, 17);
            this.chb_ShuffleMusic.TabIndex = 21;
            this.chb_ShuffleMusic.Text = "Shuffle music";
            this.chb_ShuffleMusic.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Game speed:";
            // 
            // slider_GameSpeed
            // 
            this.slider_GameSpeed.AutoSize = false;
            this.slider_GameSpeed.BackColor = System.Drawing.SystemColors.Window;
            this.slider_GameSpeed.LargeChange = 1;
            this.slider_GameSpeed.Location = new System.Drawing.Point(112, 167);
            this.slider_GameSpeed.Maximum = 6;
            this.slider_GameSpeed.Name = "slider_GameSpeed";
            this.slider_GameSpeed.RightToLeftLayout = true;
            this.slider_GameSpeed.Size = new System.Drawing.Size(153, 27);
            this.slider_GameSpeed.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Scroll rate:";
            // 
            // slider_ScrollRate
            // 
            this.slider_ScrollRate.AutoSize = false;
            this.slider_ScrollRate.BackColor = System.Drawing.SystemColors.Window;
            this.slider_ScrollRate.LargeChange = 1;
            this.slider_ScrollRate.Location = new System.Drawing.Point(112, 196);
            this.slider_ScrollRate.Maximum = 6;
            this.slider_ScrollRate.Name = "slider_ScrollRate";
            this.slider_ScrollRate.RightToLeftLayout = true;
            this.slider_ScrollRate.Size = new System.Drawing.Size(153, 27);
            this.slider_ScrollRate.TabIndex = 17;
            // 
            // chb_EnableAftermath
            // 
            this.chb_EnableAftermath.AutoSize = true;
            this.chb_EnableAftermath.Location = new System.Drawing.Point(204, 50);
            this.chb_EnableAftermath.Name = "chb_EnableAftermath";
            this.chb_EnableAftermath.Size = new System.Drawing.Size(158, 17);
            this.chb_EnableAftermath.TabIndex = 14;
            this.chb_EnableAftermath.Text = "Enable Aftermath expansion";
            this.chb_EnableAftermath.UseVisualStyleBackColor = true;
            this.chb_EnableAftermath.CheckedChanged += new System.EventHandler(this.chb_EnableAftermath_CheckedChanged);
            // 
            // chb_EnableCounterstrike
            // 
            this.chb_EnableCounterstrike.AutoSize = true;
            this.chb_EnableCounterstrike.Location = new System.Drawing.Point(204, 27);
            this.chb_EnableCounterstrike.Name = "chb_EnableCounterstrike";
            this.chb_EnableCounterstrike.Size = new System.Drawing.Size(175, 17);
            this.chb_EnableCounterstrike.TabIndex = 13;
            this.chb_EnableCounterstrike.Text = "Enable Counterstrike expansion";
            this.chb_EnableCounterstrike.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(6, 225);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Sound options:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(15, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 438);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Key_Down_Test);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.label15);
            this.tabPage5.Controls.Add(this.chb_RemapCameoIcons);
            this.tabPage5.Controls.Add(this.chb_UseDOSInterfaceMod);
            this.tabPage5.Controls.Add(this.label30);
            this.tabPage5.Controls.Add(this.chb_EnableSmallInfantry);
            this.tabPage5.Controls.Add(this.chb_UseBetaGunboat);
            this.tabPage5.Controls.Add(this.chb_UseBetaDestroyer);
            this.tabPage5.Controls.Add(this.chb_UseBetaCruiser);
            this.tabPage5.Controls.Add(this.chb_UseBetaSubmarine);
            this.tabPage5.Controls.Add(this.chb_ForceAMUnitsInMissions);
            this.tabPage5.Controls.Add(this.chb_GenerateMemoryDump);
            this.tabPage5.Controls.Add(this.label29);
            this.tabPage5.Controls.Add(this.label61);
            this.tabPage5.Controls.Add(this.label32);
            this.tabPage5.Controls.Add(this.chb_ShowAllMusic);
            this.tabPage5.Controls.Add(this.chb_UseBetaTeslaTank);
            this.tabPage5.Controls.Add(this.chb_UseAlternativeRifleSound);
            this.tabPage5.Controls.Add(this.chb_UseGrenadeThrowingSound);
            this.tabPage5.Controls.Add(this.chb_SkipScoreScreen);
            this.tabPage5.Controls.Add(this.chb_MouseWheelScrolling);
            this.tabPage5.Controls.Add(this.chb_RandomStartingSong);
            this.tabPage5.Controls.Add(this.label31);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(441, 412);
            this.tabPage5.TabIndex = 7;
            this.tabPage5.Text = "Extra options";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label15.Location = new System.Drawing.Point(6, 365);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 13);
            this.label15.TabIndex = 87;
            this.label15.Text = "Interface options:";
            // 
            // chb_RemapCameoIcons
            // 
            this.chb_RemapCameoIcons.AutoSize = true;
            this.chb_RemapCameoIcons.Location = new System.Drawing.Point(160, 389);
            this.chb_RemapCameoIcons.Name = "chb_RemapCameoIcons";
            this.chb_RemapCameoIcons.Size = new System.Drawing.Size(223, 17);
            this.chb_RemapCameoIcons.TabIndex = 86;
            this.chb_RemapCameoIcons.Text = "Remap cameo icons colors to player color";
            this.chb_RemapCameoIcons.UseVisualStyleBackColor = true;
            this.chb_RemapCameoIcons.CheckedChanged += new System.EventHandler(this.chb_RemapCameoIcons_CheckedChanged);
            // 
            // chb_UseDOSInterfaceMod
            // 
            this.chb_UseDOSInterfaceMod.AutoSize = true;
            this.chb_UseDOSInterfaceMod.Location = new System.Drawing.Point(21, 389);
            this.chb_UseDOSInterfaceMod.Name = "chb_UseDOSInterfaceMod";
            this.chb_UseDOSInterfaceMod.Size = new System.Drawing.Size(138, 17);
            this.chb_UseDOSInterfaceMod.TabIndex = 85;
            this.chb_UseDOSInterfaceMod.Text = "Use DOS interface mod";
            this.chb_UseDOSInterfaceMod.UseVisualStyleBackColor = true;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label30.Location = new System.Drawing.Point(18, 152);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(279, 13);
            this.label30.TabIndex = 84;
            this.label30.Text = "Enable recreations of beta graphics for the following units:";
            // 
            // chb_EnableSmallInfantry
            // 
            this.chb_EnableSmallInfantry.AutoSize = true;
            this.chb_EnableSmallInfantry.Location = new System.Drawing.Point(21, 129);
            this.chb_EnableSmallInfantry.Name = "chb_EnableSmallInfantry";
            this.chb_EnableSmallInfantry.Size = new System.Drawing.Size(275, 17);
            this.chb_EnableSmallInfantry.TabIndex = 83;
            this.chb_EnableSmallInfantry.Text = "Use smaller sized infantry (sized like C&&C95\'s infantry)";
            this.chb_EnableSmallInfantry.UseVisualStyleBackColor = true;
            // 
            // chb_UseBetaGunboat
            // 
            this.chb_UseBetaGunboat.AutoSize = true;
            this.chb_UseBetaGunboat.Location = new System.Drawing.Point(299, 173);
            this.chb_UseBetaGunboat.Name = "chb_UseBetaGunboat";
            this.chb_UseBetaGunboat.Size = new System.Drawing.Size(67, 17);
            this.chb_UseBetaGunboat.TabIndex = 82;
            this.chb_UseBetaGunboat.Text = "Gunboat";
            this.chb_UseBetaGunboat.UseVisualStyleBackColor = true;
            // 
            // chb_UseBetaDestroyer
            // 
            this.chb_UseBetaDestroyer.AutoSize = true;
            this.chb_UseBetaDestroyer.Location = new System.Drawing.Point(229, 173);
            this.chb_UseBetaDestroyer.Name = "chb_UseBetaDestroyer";
            this.chb_UseBetaDestroyer.Size = new System.Drawing.Size(71, 17);
            this.chb_UseBetaDestroyer.TabIndex = 81;
            this.chb_UseBetaDestroyer.Text = "Destroyer";
            this.chb_UseBetaDestroyer.UseVisualStyleBackColor = true;
            // 
            // chb_UseBetaCruiser
            // 
            this.chb_UseBetaCruiser.AutoSize = true;
            this.chb_UseBetaCruiser.Location = new System.Drawing.Point(173, 173);
            this.chb_UseBetaCruiser.Name = "chb_UseBetaCruiser";
            this.chb_UseBetaCruiser.Size = new System.Drawing.Size(58, 17);
            this.chb_UseBetaCruiser.TabIndex = 80;
            this.chb_UseBetaCruiser.Text = "Cruiser";
            this.chb_UseBetaCruiser.UseVisualStyleBackColor = true;
            // 
            // chb_UseBetaSubmarine
            // 
            this.chb_UseBetaSubmarine.AutoSize = true;
            this.chb_UseBetaSubmarine.Location = new System.Drawing.Point(99, 173);
            this.chb_UseBetaSubmarine.Name = "chb_UseBetaSubmarine";
            this.chb_UseBetaSubmarine.Size = new System.Drawing.Size(76, 17);
            this.chb_UseBetaSubmarine.TabIndex = 79;
            this.chb_UseBetaSubmarine.Text = "Submarine";
            this.chb_UseBetaSubmarine.UseVisualStyleBackColor = true;
            // 
            // chb_ForceAMUnitsInMissions
            // 
            this.chb_ForceAMUnitsInMissions.AutoSize = true;
            this.chb_ForceAMUnitsInMissions.Location = new System.Drawing.Point(21, 77);
            this.chb_ForceAMUnitsInMissions.Name = "chb_ForceAMUnitsInMissions";
            this.chb_ForceAMUnitsInMissions.Size = new System.Drawing.Size(305, 17);
            this.chb_ForceAMUnitsInMissions.TabIndex = 78;
            this.chb_ForceAMUnitsInMissions.Text = "Force Aftermath units in all missions (if Aftermath is enabled)";
            this.chb_ForceAMUnitsInMissions.UseVisualStyleBackColor = true;
            // 
            // chb_GenerateMemoryDump
            // 
            this.chb_GenerateMemoryDump.AutoSize = true;
            this.chb_GenerateMemoryDump.Location = new System.Drawing.Point(21, 344);
            this.chb_GenerateMemoryDump.Name = "chb_GenerateMemoryDump";
            this.chb_GenerateMemoryDump.Size = new System.Drawing.Size(319, 17);
            this.chb_GenerateMemoryDump.TabIndex = 77;
            this.chb_GenerateMemoryDump.Text = "Generate memory dump files in addition to normal crash dumps";
            this.chb_GenerateMemoryDump.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label29.Location = new System.Drawing.Point(6, 318);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(79, 13);
            this.label29.TabIndex = 76;
            this.label29.Text = "Debug options:";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label61.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label61.Location = new System.Drawing.Point(6, 103);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(75, 13);
            this.label61.TabIndex = 75;
            this.label61.Text = "Visual options:";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label32.Location = new System.Drawing.Point(6, 198);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(78, 13);
            this.label32.TabIndex = 74;
            this.label32.Text = "Sound options:";
            // 
            // chb_ShowAllMusic
            // 
            this.chb_ShowAllMusic.AutoSize = true;
            this.chb_ShowAllMusic.Location = new System.Drawing.Point(21, 246);
            this.chb_ShowAllMusic.Name = "chb_ShowAllMusic";
            this.chb_ShowAllMusic.Size = new System.Drawing.Size(298, 17);
            this.chb_ShowAllMusic.TabIndex = 73;
            this.chb_ShowAllMusic.Text = "Show all music ingame (instead of side or mission specific)";
            this.chb_ShowAllMusic.UseVisualStyleBackColor = true;
            // 
            // chb_UseBetaTeslaTank
            // 
            this.chb_UseBetaTeslaTank.AutoSize = true;
            this.chb_UseBetaTeslaTank.Location = new System.Drawing.Point(21, 173);
            this.chb_UseBetaTeslaTank.Name = "chb_UseBetaTeslaTank";
            this.chb_UseBetaTeslaTank.Size = new System.Drawing.Size(80, 17);
            this.chb_UseBetaTeslaTank.TabIndex = 72;
            this.chb_UseBetaTeslaTank.Text = "Tesla Tank";
            this.chb_UseBetaTeslaTank.UseVisualStyleBackColor = true;
            // 
            // chb_UseAlternativeRifleSound
            // 
            this.chb_UseAlternativeRifleSound.AutoSize = true;
            this.chb_UseAlternativeRifleSound.Location = new System.Drawing.Point(21, 292);
            this.chb_UseAlternativeRifleSound.Name = "chb_UseAlternativeRifleSound";
            this.chb_UseAlternativeRifleSound.Size = new System.Drawing.Size(286, 17);
            this.chb_UseAlternativeRifleSound.TabIndex = 71;
            this.chb_UseAlternativeRifleSound.Text = "Use alternative rifle shooting sound for the Rifle Infantry";
            this.chb_UseAlternativeRifleSound.UseVisualStyleBackColor = true;
            // 
            // chb_UseGrenadeThrowingSound
            // 
            this.chb_UseGrenadeThrowingSound.AutoSize = true;
            this.chb_UseGrenadeThrowingSound.Location = new System.Drawing.Point(21, 269);
            this.chb_UseGrenadeThrowingSound.Name = "chb_UseGrenadeThrowingSound";
            this.chb_UseGrenadeThrowingSound.Size = new System.Drawing.Size(244, 17);
            this.chb_UseGrenadeThrowingSound.TabIndex = 70;
            this.chb_UseGrenadeThrowingSound.Text = "Use grenade throwing sound for the Grenadier";
            this.chb_UseGrenadeThrowingSound.UseVisualStyleBackColor = true;
            // 
            // chb_SkipScoreScreen
            // 
            this.chb_SkipScoreScreen.AutoSize = true;
            this.chb_SkipScoreScreen.Location = new System.Drawing.Point(21, 54);
            this.chb_SkipScoreScreen.Name = "chb_SkipScoreScreen";
            this.chb_SkipScoreScreen.Size = new System.Drawing.Size(319, 17);
            this.chb_SkipScoreScreen.TabIndex = 69;
            this.chb_SkipScoreScreen.Text = "Skip displaying the score screen in both single- and multiplayer";
            this.chb_SkipScoreScreen.UseVisualStyleBackColor = true;
            // 
            // chb_MouseWheelScrolling
            // 
            this.chb_MouseWheelScrolling.AutoSize = true;
            this.chb_MouseWheelScrolling.Location = new System.Drawing.Point(21, 31);
            this.chb_MouseWheelScrolling.Name = "chb_MouseWheelScrolling";
            this.chb_MouseWheelScrolling.Size = new System.Drawing.Size(260, 17);
            this.chb_MouseWheelScrolling.TabIndex = 68;
            this.chb_MouseWheelScrolling.Text = "Enable scrolling the sidebar with the mouse wheel";
            this.chb_MouseWheelScrolling.UseVisualStyleBackColor = true;
            // 
            // chb_RandomStartingSong
            // 
            this.chb_RandomStartingSong.AutoSize = true;
            this.chb_RandomStartingSong.Location = new System.Drawing.Point(21, 223);
            this.chb_RandomStartingSong.Name = "chb_RandomStartingSong";
            this.chb_RandomStartingSong.Size = new System.Drawing.Size(264, 17);
            this.chb_RandomStartingSong.TabIndex = 67;
            this.chb_RandomStartingSong.Text = "Randomize the starting song when a match begins";
            this.chb_RandomStartingSong.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label31.Location = new System.Drawing.Point(6, 5);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(84, 13);
            this.label31.TabIndex = 65;
            this.label31.Text = "General options:";
            // 
            // Form1
            // 
            this.AcceptButton = this.but_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.but_Cancel;
            this.ClientSize = new System.Drawing.Size(479, 488);
            this.Controls.Add(this.but_ok);
            this.Controls.Add(this.but_Cancel);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Red Alert 95 Config";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_HotKeyEditor)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Contrast)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Tint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Color)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Slider_MusicVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_SoundVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_GameSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slider_ScrollRate)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button But_UseProSetup;
        private System.Windows.Forms.Button but_ResetDefaults;
        private System.Windows.Forms.Button but_ClearSelectedKey;
        private System.Windows.Forms.DataGridView grid_HotKeyEditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotkeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHotkeyValue;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label16;
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
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtb_MaxFPS;
        private System.Windows.Forms.TextBox txtb_StretchCustomHeight;
        private System.Windows.Forms.TextBox txtb_StretchCustomWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radiob_RendererOpenGL;
        private System.Windows.Forms.RadioButton radiob_RendererGDI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtb_resoCustomHeight;
        private System.Windows.Forms.RadioButton radiob_reso640x400;
        private System.Windows.Forms.TextBox txtb_resoCustomWidth;
        private System.Windows.Forms.RadioButton radiob_reso640x480;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RadioButton radiob_reso800x600;
        private System.Windows.Forms.RadioButton radiob_resoCustom;
        private System.Windows.Forms.RadioButton radiob_reso1024x768;
        private System.Windows.Forms.Button but_DetectReso;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.CheckBox chb_UseWindowBoxing;
        private System.Windows.Forms.CheckBox chb_ShowWindowedBorder;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox cmbox_BitsPerPixels;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.CheckBox chb_AutoAdjustMouse;
        private System.Windows.Forms.CheckBox chb_RunWindowed;
        private System.Windows.Forms.CheckBox chb_AllowHardwareFilledBits;
        private System.Windows.Forms.CheckBox chb_BackBufferVideoMemory;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label txt_StretchingScaling;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbox_ScalingFilter;
        private System.Windows.Forms.CheckBox chb_StretchCustom;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label txt_UseRAAspectRatio;
        private System.Windows.Forms.CheckBox chb_UseRAAspectRatio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox chb_EnableCnCDDraw;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button but_ResetVisualOptions;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TrackBar slider_Contrast;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TrackBar slider_Tint;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TrackBar slider_Color;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TrackBar slider_Brightness;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox chb_UseLanPatch;
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
        private System.Windows.Forms.CheckBox chb_EnableAftermath;
        private System.Windows.Forms.CheckBox chb_EnableCounterstrike;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TextBox textb_Credits;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.CheckBox chb_Crates;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.CheckBox chb_OreRegenerates;
        private System.Windows.Forms.Label labelderp;
        private System.Windows.Forms.CheckBox chb_Bases;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.CheckBox chb_CaptureTheFlag;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.CheckBox chb_ShroudRegrows;
        private System.Windows.Forms.ComboBox cmbox_AIDifficulty;
        private System.Windows.Forms.ComboBox cmbox_AIPlayers;
        private System.Windows.Forms.ComboBox cmbox_TechLevel;
        private System.Windows.Forms.ComboBox cmbox_UnitCount;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.CheckBox chb_DisplayAftermathMaps;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.CheckBox chb_DisplayCounterstrikeMaps;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.CheckBox chb_DisplayOriginalMaps;
        private System.Windows.Forms.CheckBox chb_DeinterlaceVideos;
        private System.Windows.Forms.CheckBox chb_VideoStretching;
        private System.Windows.Forms.ComboBox cmbox_GameLanguage;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.CheckBox chb_NoCD;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.CheckBox chb_ShowAllMusic;
        private System.Windows.Forms.CheckBox chb_UseBetaTeslaTank;
        private System.Windows.Forms.CheckBox chb_UseAlternativeRifleSound;
        private System.Windows.Forms.CheckBox chb_UseGrenadeThrowingSound;
        private System.Windows.Forms.CheckBox chb_SkipScoreScreen;
        private System.Windows.Forms.CheckBox chb_MouseWheelScrolling;
        private System.Windows.Forms.CheckBox chb_RandomStartingSong;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.CheckBox chb_GenerateMemoryDump;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.CheckBox chb_ForceAMUnitsInMissions;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.CheckBox chb_EnableSmallInfantry;
        private System.Windows.Forms.CheckBox chb_UseBetaGunboat;
        private System.Windows.Forms.CheckBox chb_UseBetaDestroyer;
        private System.Windows.Forms.CheckBox chb_UseBetaCruiser;
        private System.Windows.Forms.CheckBox chb_UseBetaSubmarine;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Label label100;
        private System.Windows.Forms.CheckBox chb_RemapCameoIcons;
        private System.Windows.Forms.CheckBox chb_UseDOSInterfaceMod;
        private System.Windows.Forms.Label label15;

    }
}

