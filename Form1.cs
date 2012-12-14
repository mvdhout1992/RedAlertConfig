using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;
using System.Threading;
using System.Globalization;
using RedAlertConfig;

namespace RedAlertConfig
{
    public partial class Form1 : Form
    {

        public int ResoWidth, ResoHeight;

        public Form1()
        {
            Files.Init();
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists("1maplist_original_game.pkt") == true)
            {
                this.chb_DisplayOriginalMaps.Checked = true;
            }

            if ((File.Exists("2maplist_counterstrike.pkt") == true))
            {
                this.chb_DisplayCounterstrikeMaps.Checked = true;
            }

            if ((File.Exists("3maplist_aftermath.pkt") == true))
            {
                this.chb_DisplayAftermathMaps.Checked = true;
            }

           if (File.Exists("ddraw.dll") == true)
           {
                this.chb_EnableCnCDDraw.Checked = true;
           }
           else
           {
               this.chb_EnableCnCDDraw.Checked = false;
               chb_EnableCnCDDraw_CheckedChanged(this, null);
           }

           if (File.Exists("smallinfantry.mix") == true)
           {
               this.chb_EnableSmallInfantry.Checked = true;
           }
           else
           {
               this.chb_EnableSmallInfantry.Checked = false;
           }

           if (File.Exists("thipx32.dll") == true)
           {
               this.chb_UseLanPatch.Checked = true;
           }
           else
           {
               this.chb_UseLanPatch.Checked = false;
           }

           if (File.Exists("counterstrike.mix") == true)
           {
               this.chb_EnableCounterstrike.Checked = true;
           }

           else
           {
               this.chb_EnableCounterstrike.Checked = false;
           }

           if (File.Exists("aftermath.mix") == true)
           {
               this.chb_EnableAftermath.Checked = true;
           }
           else
           {
               this.chb_EnableAftermath.Checked = false;
               this.chb_ForceAftermathOnline.Checked = false;
               this.chb_ForceAftermathOnline.Enabled = false;
               this.chb_ForceAftermathOnlineFastBuildSpeed.Checked = false;
               this.chb_ForceAftermathOnlineFastBuildSpeed.Enabled = false;
           }

           this.chb_ForceAftermathOnlineFastBuildSpeed.Checked = false;
           this.chb_ForceAftermathOnline.Checked = false;

           if (File.Exists("rules.ini") == true)
           {
                Crc32 crc32 = new Crc32();
                String hash = String.Empty;

                using (FileStream fs = File.Open("rules.ini", FileMode.Open))
    	        foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                // MessageBox.Show(hash);

                if (hash == "c165ab92")
                {
                    this.chb_ForceAftermathOnline.Checked = true;
                }
                if (hash == "adabee0b")
                {
                    this.chb_ForceAftermathOnlineFastBuildSpeed.Checked = true;
                }
           }

           if (Files.RedAlertINI.getBoolValue("ConfigTool", "UseRAAspectRatio", false) == true)
           {
               ResoWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
               ResoHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);
           }
           else
           {
               ResoWidth = Files.RedAlertINI.getIntValue("Options", "Width", 640);
               ResoHeight = Files.RedAlertINI.getIntValue("Options", "Height", 480);
           }

            String Credits = Files.RedAlertINI.getIntValue("MultiplayerDefaults", "Money", 0).ToString();
            this.textb_Credits.Text = Credits;

           this.txtb_resoCustomHeight.Enabled = false;
           this.txtb_resoCustomWidth.Enabled = false;
           this.but_DetectReso.Enabled = false;

           this.txtb_resoCustomHeight.Text = ResoHeight.ToString();
           this.txtb_resoCustomWidth.Text = ResoWidth.ToString();

            if (ResoWidth == 640 && ResoHeight == 400)
            {
                this.radiob_reso640x400.Checked = true;
            }
            else if (ResoWidth == 640 && ResoHeight == 479)
            {
                this.radiob_reso640x480.Checked = true;
            }
            else if (ResoWidth == 800 && ResoHeight == 600)
            {
                this.radiob_reso800x600.Checked = true;
            }
            else if (ResoWidth == 1024 && ResoHeight == 768)
            {
                this.radiob_reso1024x768.Checked = true;
            }
            else
            {
                this.radiob_resoCustom.Checked = true;
            }
            Update_Use_RA_Aspect_Ratio();

//            this.txtb_StretchCustomWidth.Enabled = false;
//            this.txtb_StretchCustomHeight.Enabled = false;
            
            int StretchWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
            int StretchHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);

            this.txtb_StretchCustomWidth.Text = StretchWidth.ToString();
            this.txtb_StretchCustomHeight.Text = StretchHeight.ToString();

            if (this.txtb_StretchCustomWidth.Text == "0") this.txtb_StretchCustomWidth.Text = "";
            if (this.txtb_StretchCustomHeight.Text == "0") this.txtb_StretchCustomHeight.Text = "";

            txtb_Handle.Text = Files.RedAlertINI.getStringValue("MultiPlayer", "Handle", "");

            int UnitCount = Files.RedAlertINI.getIntValue("MultiPlayerDefaults", "UnitCount", 0);
            if (UnitCount > 12) UnitCount = 12; if (UnitCount < 0) UnitCount = 0;
            this.cmbox_UnitCount.SelectedIndex = UnitCount;

            int TechLevel = Files.RedAlertINI.getIntValue("MultiPlayerDefaults", "TechLevel", 10);
            if (TechLevel > 10) TechLevel = 10; if (TechLevel < 1) TechLevel = 1;
            this.cmbox_TechLevel.SelectedIndex = TechLevel - 1;

            int AIPlayers = Files.RedAlertINI.getIntValue("MultiPlayerDefaults", "AIPlayers", 1);
            if (AIPlayers > 7) AIPlayers = 7; if (AIPlayers < 1) AIPlayers = 1;
            this.cmbox_AIPlayers.SelectedIndex = AIPlayers-1;

            int AIDifficulty = Files.RedAlertINI.getIntValue("MultiPlayerDefaults", "AIDifficulty", 1);
            if (AIDifficulty > 2) AIPlayers = 2; if (AIDifficulty < 0) AIDifficulty = 0;
            this.cmbox_AIDifficulty.SelectedIndex = AIDifficulty;

            if (Files.RedAlertINI.getBoolValue("Options", "PlayEnglishIntro", false) == true)
            {
                chb_PlayIntro.Checked = true;
            }

            if (!File.Exists("movies1.mix") && !File.Exists("movies2.mix"))
            {
                chb_PlayIntro.Enabled = false;
//                chb_PlayIntro.Text = "Play intro cinematic (requires movie files)";
            }

            if (Files.RedAlertINI.getIntValue("Options", "VideoInterlaceMode", 2) == 2)
            {
                this.chb_DeinterlaceVideos.Checked = true;
            }

            if (Files.RedAlertINI.getBoolValue("Options", "RandomStartingSong", false) == true)
            {
                this.chb_RandomStartingSong.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "ShowAllMusic", false) == true)
            {
                this.chb_ShowAllMusic.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "SkipScoreScreen", false) == true)
            {
                this.chb_SkipScoreScreen.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "IsScoreRepeat", false) == true)
            {
                this.chb_RepeatMusic.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "IsScoreShuffle", false) == true)
            {
                this.chb_ShuffleMusic.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "AutoScroll", false) == true)
            {
                this.chb_Autoscroll.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("MultiplayerDefaults", "ShroudRegrows", false) == true)
            {
                this.chb_ShroudRegrows.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("MultiplayerDefaults", "CaptureTheFlag", false) == true)
            {
                this.chb_CaptureTheFlag.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("MultiplayerDefaults", "Crates", false) == true)
            {
                this.chb_Crates.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("MultiplayerDefaults", "Bases", false) == true)
            {
                this.chb_Bases.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("MultiplayerDefaults", "OreRegenerates", false) == true)
            {
                this.chb_OreRegenerates.Checked = true;
            }

            double derp;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Volume", "0"),  out derp) == false)
            {
                derp = 0;
            }
            int SoundVolume = ((int)(derp * 1000));
            this.slider_SoundVolume.Value = SoundVolume;

            double derp2;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "MultiplayerScoreVolume", "0"), out derp2) == false)
            {
                derp2 = 0;
            }
            int MusicVolume = ((int)(derp2 * 1000));
            this.Slider_MusicVolume.Value = MusicVolume;

            double derp3;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Brightness", "0"), out derp3) == false)
            {
                derp3 = 0;
            }
            int Brightness = ((int)(derp3 * 1000));
            this.slider_Brightness.Value = Brightness;

            double derp4;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Color", "0"), out derp4) == false)
            {
                derp4 = 0;
            }
            int Color = ((int)(derp4 * 1000));
            this.slider_Color.Value = Color;

            double derp5;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Tint", "0"), out derp5) == false)
            {
                derp5 = 0;
            }
            int Tint = ((int)(derp5 * 1000));
            this.slider_Tint.Value = Tint;

            double derp6;
            if (Double.TryParse(Files.RedAlertINI.getStringValue("Options", "Contrast", "0"), out derp6) == false)
            {
                derp5 = 0;
            }
            int Contrast = ((int)(derp6 * 1000));
            this.slider_Contrast.Value = Contrast;

            int GameSpeed = Files.RedAlertINI.getIntValue("Options", "GameSpeed", 3);
            this.slider_GameSpeed.Value = 6 - GameSpeed;

            int ScrollRate = Files.RedAlertINI.getIntValue("Options", "ScrollRate", 3);
            this.slider_ScrollRate.Value = 6 - ScrollRate;

            int Side = Files.RedAlertINI.getIntValue("MultiPlayer", "Side", 2);
            if (Side == 0 || Side == 1)
            {
                Side += 6;
            }
            else if (Side > 1 && Side < 8)
            {
                Side -= 2;
            }
            else
            {
                Side = 0;
            }

            this.cmbox_Side.SelectedIndex = Side;

            this.cmbox_Color.SelectedIndex = Files.RedAlertINI.getIntValue("MultiPlayer", "Color", 0);

            String Renderer = Files.DDrawINI.getStringValue("ddraw", "renderer", "opengl");

            String ScalingFilter = Files.DDrawINI.getStringValue("ddraw", "filter", "");

            if (ScalingFilter.ToLower() == "nearest")
            {
                this.cmbox_ScalingFilter.SelectedIndex = 0;
            }
            else if (ScalingFilter.ToLower() == "linear")
            {
                this.cmbox_ScalingFilter.SelectedIndex = 1;
            }

            if (Renderer.ToLower() == "gdi")
            {
                this.radiob_RendererGDI.Checked = true;

            }
            else
            {
                this.radiob_RendererOpenGL.Checked = true;

            }
            radiob_RendererOpenGL_CheckedChanged(this, null);
            radiob_RendererGDI_CheckedChanged(this, null);

            if (Files.RedAlertINI.getBoolValue("ConfigTool", "UseRAAspectRatio", false) == true)
            {
                this.chb_UseRAAspectRatio.Checked = true;
            }
            else if (StretchHeight != 0 && StretchWidth != 0)
            {
                this.chb_StretchCustom.Checked = true;
            }
            if (Files.RedAlertINI.getBoolValue("Options", "HardwareFills", false) == true)
            {
                this.chb_AllowHardwareFilledBits.Checked = true;
            }
            if (this.chb_EnableCnCDDraw.Checked == true)
            {
                this.chb_AllowHardwareFilledBits.Enabled = false;
            }

            if (Files.RedAlertINI.getBoolValue("Options", "VideoBackBuffer", false) == true)
            {
                this.chb_BackBufferVideoMemory.Checked = true;
            }

            if (Files.DDrawINI.getBoolValue("ddraw", "windowed", false) == true)
            {
                this.chb_RunWindowed.Checked = true;
            }
            if (Files.DDrawINI.getBoolValue("ddraw", "border", false) == true)
            {
                this.chb_ShowWindowedBorder.Checked = true;
            }

            if (Files.DDrawINI.getBoolValue("ddraw", "boxing", false) == true)
            {
                this.chb_UseWindowBoxing.Checked = true;
            }
            if (Files.DDrawINI.getBoolValue("ddraw", "adjmouse", false) == true)
            {
                this.chb_AutoAdjustMouse.Checked = true;
            }

            if (Files.DDrawINI.getBoolValue("ddraw", "mhack", false) == true)
            {
                this.chb_EnableMouseHack.Checked = true;
            }

            if (Files.DDrawINI.getBoolValue("ddraw", "vhack", false) == true)
            {
                this.chb_VideoStretching.Checked = true;
            }

            if (Files.DDrawINI.getBoolValue("ddraw", "vsync", false) == true)
            {
                this.chb_EnableVSync.Checked = true;
            }
            if (Files.DDrawINI.getBoolValue("ddraw", "singlecpu", false) == true)
            {
                this.chb_ForceSingleCPU.Checked = true;
            }

            this.txtb_MaxFPS.Text = Files.DDrawINI.getStringValue("ddraw", "maxfps", "");

            int BPP = Files.DDrawINI.getIntValue("ddraw", "bpp", 0);
            int BPPIndex = 0;

            if (BPP == 16)
            {
                BPPIndex = 1;
            }
            else if (BPP == 24)
            {
                BPPIndex = 2;
            }
            else if (BPP == 32)
            {
                BPPIndex = 3;
            }

            this.cmbox_BitsPerPixels.SelectedIndex = BPPIndex;

            this.tabControl1.SelectedIndex = Files.RedAlertINI.getIntValue("ConfigTool", "ConfigToolTab", 0);

            this.grid_HotKeyEditor.Rows.Add(50);

            // First row is hidden and selected, to prevent the actual "first" row from
            // getting selected automatically
            this.grid_HotKeyEditor.CurrentCell = this.grid_HotKeyEditor.Rows[0].Cells[0];
            this.grid_HotKeyEditor.Rows[0].Visible = false;

            //           grid_HotKeyEditor.Rows[0].Cells["ColumnHotkeyName"].Value = "KeyForceMove1";
            Set_Row_From_Hotkey_INI("KeyForceMove1", 1);
            Set_Row_From_Hotkey_INI("KeyForceMove2", 2);
            Set_Row_From_Hotkey_INI("KeyForceAttack1", 3);
            Set_Row_From_Hotkey_INI("KeyForceAttack2", 4);
            Set_Row_From_Hotkey_INI("KeySelect1", 5);
            Set_Row_From_Hotkey_INI("KeySelect2", 6);
            Set_Row_From_Hotkey_INI("KeyScatter", 7);
            Set_Row_From_Hotkey_INI("KeyStop", 8);
            Set_Row_From_Hotkey_INI("KeyGuard", 9);
            Set_Row_From_Hotkey_INI("KeyNext", 10);
            Set_Row_From_Hotkey_INI("KeyPrevious", 11);
            Set_Row_From_Hotkey_INI("KeyFormation", 12);
            Set_Row_From_Hotkey_INI("KeyHome1", 13);
            Set_Row_From_Hotkey_INI("KeyHome2", 14);
            Set_Row_From_Hotkey_INI("KeyBase", 15);
            Set_Row_From_Hotkey_INI("KeyResign", 16);
            Set_Row_From_Hotkey_INI("KeyAlliance", 17);
            Set_Row_From_Hotkey_INI("KeyBookmark1", 18);
            Set_Row_From_Hotkey_INI("KeyBookmark2", 19);
            Set_Row_From_Hotkey_INI("KeyBookmark3", 20);
            Set_Row_From_Hotkey_INI("KeyBookmark4", 21);
            Set_Row_From_Hotkey_INI("KeySelectView", 22);
            Set_Row_From_Hotkey_INI("KeyRepairToggle", 23);
            Set_Row_From_Hotkey_INI("KeyRepairOn", 24);
            Set_Row_From_Hotkey_INI("KeyRepairOff", 25);
            Set_Row_From_Hotkey_INI("KeySellToggle", 26);
            Set_Row_From_Hotkey_INI("KeySellOn", 27);
            Set_Row_From_Hotkey_INI("KeySellOff", 28);
            Set_Row_From_Hotkey_INI("KeyMapToggle", 29);
            Set_Row_From_Hotkey_INI("KeySidebarUp", 30);
            Set_Row_From_Hotkey_INI("KeySidebarDown", 31);
            Set_Row_From_Hotkey_INI("KeyOption1", 32);
            Set_Row_From_Hotkey_INI("KeyOption2", 33);
            Set_Row_From_Hotkey_INI("KeyScrollLeft", 34);
            Set_Row_From_Hotkey_INI("KeyScrollRight", 35);
            Set_Row_From_Hotkey_INI("KeyScrollUp", 36);
            Set_Row_From_Hotkey_INI("KeyScrollDown", 37);
            Set_Row_From_Hotkey_INI("KeyQueueMove1", 38);
            Set_Row_From_Hotkey_INI("KeyQueueMove2", 39);
            Set_Row_From_Hotkey_INI("KeyTeam1", 40);
            Set_Row_From_Hotkey_INI("KeyTeam2", 41);
            Set_Row_From_Hotkey_INI("KeyTeam3", 42);
            Set_Row_From_Hotkey_INI("KeyTeam4", 43);
            Set_Row_From_Hotkey_INI("KeyTeam5", 44);
            Set_Row_From_Hotkey_INI("KeyTeam6", 45);
            Set_Row_From_Hotkey_INI("KeyTeam7", 46);
            Set_Row_From_Hotkey_INI("KeyTeam8", 47);
            Set_Row_From_Hotkey_INI("KeyTeam9", 48);
            Set_Row_From_Hotkey_INI("KeyTeam10", 49);

//            this.grid_HotKeyEditor.Select();
        }

        private void Update_Use_RA_Aspect_Ratio()
        {
            this.chb_UseRAAspectRatio.Enabled = true;
            this.label18.Enabled = true;
            this.txt_UseRAAspectRatio.Enabled = true;

            int CustomResoWidth;
            if (Int32.TryParse(this.txtb_resoCustomWidth.Text, out CustomResoWidth) == false)
            {
                CustomResoWidth = 0;
            }

            int CustomResoHeight;
            if (Int32.TryParse(this.txtb_resoCustomHeight.Text, out CustomResoHeight) == false)
            {
                CustomResoHeight = 0;
            }

            if (this.radiob_reso640x400.Checked == true)
            {
                CustomResoWidth = 640;
                CustomResoHeight = 400;
            }
            else if (this.radiob_reso640x480.Checked == true)
            {
                CustomResoWidth = 640;
                CustomResoHeight = 480;
            }
            else if (this.radiob_reso800x600.Checked == true)
            {
                CustomResoWidth = 800;
                CustomResoHeight = 600;
            }
            else if (this.radiob_reso1024x768.Checked == true)
            {
                CustomResoWidth = 1024;
                CustomResoHeight = 768;
            }

            this.txt_UseRAAspectRatio.Text = String.Format("({0}x{1} stretched to {0}x{2})",
                (int)CustomResoWidth, (int)(CustomResoHeight / 1.2), (int)CustomResoHeight);

            if (this.radiob_reso640x400.Checked == true || (this.radiob_resoCustom.Checked == true
            && (CustomResoWidth < 640 || CustomResoHeight < 480)))
            //if (ResoWidth < 640 || ResoHeight < 480)
            {
                this.chb_UseRAAspectRatio.Enabled = false;
                this.chb_UseRAAspectRatio.Checked= false;

                this.label18.Enabled = false;
                this.txt_UseRAAspectRatio.Enabled = false;
                this.txt_UseRAAspectRatio.Text = "(needs to be at least 640x480)";
            }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }


        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void checkBox20_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cncnet.org");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cncnet.exe";
            process.StartInfo.Arguments = "-CFG";
            process.StartInfo.UseShellExecute = false;
            process.Start();
        }

        private void chb_EnableSmallInfantry_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void but_Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();      
        }

        private void but_ok_Click(object sender, EventArgs e)
        {

            if (this.chb_EnableCnCDDraw.Checked == true)
            {
               this.chb_AllowHardwareFilledBits.Checked = false;
               Files.RedAlertINI.setBoolValue("Options", "HardwareFills", false);
               Files.RedAlertINI.setBoolValue("ConfigTool", "UseRAAspectRatio", false);

             //  Remove_Colour_Registry_Fix();
             //  Disable_Win95_RA95_Compatibility_Mode();
            }
            else
            {
             //   Apply_Colour_Registry_Fix();
             //   Enable_Win95_RA95_Compatibility_Mode();
            }

            if (this.radiob_reso640x400.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 400);
            }
            else if (this.radiob_reso640x480.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 479);
            }
            else if (this.radiob_reso800x600.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 800);
                Files.RedAlertINI.setIntValue("Options", "Height", 600);
            }
            else if (this.radiob_reso1024x768.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 1024);
                Files.RedAlertINI.setIntValue("Options", "Height", 768);
            }
            else if (this.radiob_resoCustom.Checked == true)
            {
                int ResolutionWidth;
                if (Int32.TryParse(this.txtb_resoCustomWidth.Text, out ResolutionWidth) == false)
                {
                    ResolutionWidth = 0;
                }
                Files.RedAlertINI.setIntValue("Options", "Width", ResolutionWidth);

                int ResolutionHeight;
                if (Int32.TryParse(this.txtb_resoCustomHeight.Text, out ResolutionHeight) == false)
                {
                    ResolutionHeight = 0;
                }
                Files.RedAlertINI.setIntValue("Options", "Height", ResolutionHeight);
            }

            if (this.chb_UseRAAspectRatio.Checked == false)
            {
                Files.RedAlertINI.setBoolValue("ConfigTool", "UseRAAspectRatio", false);
            }
            if (this.chb_UseRAAspectRatio.Checked == true)
            {
                int RAHeight = Files.RedAlertINI.getIntValue("Options", "Height", 0);
                Files.DDrawINI.setIntValue("ddraw", "height", RAHeight);
                Files.RedAlertINI.setIntValue("Options", "Height", (int)(RAHeight / 1.2));

                Files.RedAlertINI.setBoolValue("ConfigTool", "UseRAAspectRatio", true);

                int RAWidth = Files.RedAlertINI.getIntValue("Options", "Width", 0);
                Files.DDrawINI.setIntValue("ddraw", "width", RAWidth);
            }
            else if (this.chb_StretchCustom.Checked == true)
            {
                int StretchWidth;
                if (Int32.TryParse(this.txtb_StretchCustomWidth.Text, out StretchWidth) == false)
                {
                    StretchWidth = 0;
                }
                Files.DDrawINI.setIntValue("ddraw", "width", StretchWidth);

                int StretchHeight;
                if (Int32.TryParse(this.txtb_StretchCustomHeight.Text, out StretchHeight) == false)
                {
                    StretchHeight = 0;
                }
                Files.DDrawINI.setIntValue("ddraw", "height", StretchHeight);
            }
            else
            {
                Files.DDrawINI.setIntValue("ddraw", "height", 0);
                Files.DDrawINI.setIntValue("ddraw", "width", 0);
            }

            Files.RedAlertINI.setStringValue("MultiPlayer", "Handle", txtb_Handle.Text);

            if (chb_PlayIntro.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "PlayEnglishIntro", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "PlayEnglishIntro", false);
            }

            if (chb_SkipScoreScreen.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "SkipScoreScreen", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "SkipScoreScreen", false);
            }

            if (this.chb_ShowAllMusic.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "ShowAllMusic", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "ShowAllMusic", false);
            }

            if (this.chb_RepeatMusic.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreRepeat", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreRepeat", false);
            }

            if (this.chb_ShuffleMusic.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreShuffle", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "IsScoreShuffle", false);
            }

            if (this.chb_Autoscroll.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "AutoScroll", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "AutoScroll", false);
            }

            if (this.chb_DeinterlaceVideos.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "VideoInterlaceMode", 2);
            }
            else
            {
                Files.RedAlertINI.setIntValue("Options", "VideoInterlaceMode", 0);
            }

            Files.RedAlertINI.setStringValue("MultiplayerDefaults", "Money", this.textb_Credits.Text);

            double Volume = ((double)this.slider_SoundVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Volume", Volume.ToString());

            double MusicVolume = ((double)this.Slider_MusicVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "ScoreVolume", MusicVolume.ToString());
            Files.RedAlertINI.setStringValue("Options", "MultiplayerScoreVolume", MusicVolume.ToString());

            int GameSpeed = 6 - this.slider_GameSpeed.Value;
            Files.RedAlertINI.setIntValue("Options", "GameSpeed", GameSpeed);

            int ScrollRate = 6 - this.slider_ScrollRate.Value;
            Files.RedAlertINI.setIntValue("Options", "ScrollRate", ScrollRate);

            int Side = this.cmbox_Side.SelectedIndex;

            Files.RedAlertINI.setIntValue("MultiPlayer", "Side", this.cmbox_Side.SelectedIndex + 2);

            if (Side == 6 || Side == 7)
            {
                Side -= 6;
                Files.RedAlertINI.setIntValue("MultiPlayer", "Side", Side);
            }

            Files.RedAlertINI.setIntValue("MultiPlayer", "Color", this.cmbox_Color.SelectedIndex);

            if (this.radiob_RendererGDI.Checked == true)
            {
                Files.DDrawINI.setStringValue("ddraw", "renderer", "gdi");
            }
            else if (this.radiob_RendererOpenGL.Checked == true)
            {
                Files.DDrawINI.setStringValue("ddraw", "renderer", "opengl");
            }

            if (this.cmbox_ScalingFilter.SelectedIndex == 0)
            {
                Files.DDrawINI.setStringValue("ddraw", "filter", "nearest");
            }
            else if (this.cmbox_ScalingFilter.SelectedIndex == 1)
            {
                Files.DDrawINI.setStringValue("ddraw", "filter", "linear");
            }

            if (this.chb_RunWindowed.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "windowed", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "windowed", false);
            }

            if (this.chb_ShowWindowedBorder.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "border", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "border", false);
            }

            if (this.chb_UseWindowBoxing.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "boxing", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "boxing", false);
            }

            if (this.chb_AutoAdjustMouse.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "adjmouse", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "adjmouse", false);
            }

            if (this.chb_EnableMouseHack.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "mhack", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "mhack", false);
            }

            if (this.chb_ForceSingleCPU.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "singlecpu", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "singlecpu", false);
            }

            if (this.chb_VideoStretching.Checked == true)
            {
                Files.DDrawINI.setBoolValue("ddraw", "vhack", true);
            }
            else
            {
                Files.DDrawINI.setBoolValue("ddraw", "vhack", false);
            }

            if (this.chb_BackBufferVideoMemory.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "VideoBackBuffer", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "VideoBackBuffer", false);
            }

            if (this.chb_AllowHardwareFilledBits.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "HardwareFills", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "HardwareFills", false);
            }

            if (this.chb_ShroudRegrows.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "ShroudRegrows", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "ShroudRegrows", false);
            }

            if (this.chb_CaptureTheFlag.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "CaptureTheFlag", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "CaptureTheFlag", false);
            }

            if (this.chb_Crates.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "Crates", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "Crates", false);
            }

            if (this.chb_RandomStartingSong.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "RandomStartingSong", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "RandomStartingSong", false);
            }

            if (this.chb_Bases.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "Bases", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "Bases", false);
            }

            if (this.chb_OreRegenerates.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "OreRegenerates", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("MultiplayerDefaults", "OreRegenerates", false);
            }

            int MaxFPS;
            if (Int32.TryParse(this.txtb_MaxFPS.Text, out MaxFPS) == false)
            {
                MaxFPS = 0;
            }
            Files.DDrawINI.setIntValue("ddraw", "maxfps", MaxFPS);

            int BPPIndex = this.cmbox_BitsPerPixels.SelectedIndex;
            int BPP = 0;

            if (BPPIndex == 1)
            {
                BPP = 16;
            }
            else if (BPPIndex == 2)
            {
                BPP = 24;
            }
            else if (BPPIndex == 3)
            {
                BPP = 32;
            }

            Files.DDrawINI.setIntValue("ddraw", "bpp", BPP);

            int UnitCount = this.cmbox_UnitCount.SelectedIndex;
            Files.RedAlertINI.setIntValue("MultiplayerDefaults", "UnitCount", UnitCount);

            int TechLevel= this.cmbox_TechLevel.SelectedIndex;
            Files.RedAlertINI.setIntValue("MultiplayerDefaults", "TechLevel", TechLevel+1);

            int AIPlayers = this.cmbox_AIPlayers.SelectedIndex;
            Files.RedAlertINI.setIntValue("MultiplayerDefaults", "AIPlayers", AIPlayers+1);

            int AIDifficulty = this.cmbox_AIDifficulty.SelectedIndex;
            Files.RedAlertINI.setIntValue("MultiplayerDefaults", "AIDifficulty", AIDifficulty);

/*            if (File.Exists("1maplist_original_game.pkt") == true)
            {
                this.chb_DisplayOriginalMaps.Checked = true;
            }

            if ((File.Exists("2maplist_counterstrike.pkt") == true))
            {
                this.chb_DisplayCounterstrikeMaps.Checked = true;
            }

            if ((File.Exists("3maplist_aftermath.pkt") == true))
            {
                this.chb_DisplayAftermathMaps.Checked = true;
            } */

            if (this.chb_DisplayOriginalMaps.Checked == true && !File.Exists("1maplist_original_game.pkt"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "1maplist_original_game.pkt",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "1maplist_original_game.pkt");
            }
            else if (this.chb_DisplayOriginalMaps.Checked == false && File.Exists("1maplist_original_game.pkt"))
            {
                File.Delete("1maplist_original_game.pkt");
            }

            if (this.chb_DisplayCounterstrikeMaps.Checked == true && !File.Exists("2maplist_counterstrike.pkt"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "2maplist_counterstrike.pkt",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "2maplist_counterstrike.pkt");
            }
            else if (this.chb_DisplayCounterstrikeMaps.Checked == false && File.Exists("2maplist_counterstrike.pkt"))
            {
                File.Delete("2maplist_counterstrike.pkt");
            }

            if (this.chb_DisplayAftermathMaps.Checked == true && !File.Exists("3maplist_aftermath.pkt"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "3maplist_aftermath.pkt",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "3maplist_aftermath.pkt");
            }
            else if (this.chb_DisplayAftermathMaps.Checked == false && File.Exists("3maplist_aftermath.pkt"))
            {
                File.Delete("3maplist_aftermath.pkt");
            }

            if (this.chb_EnableCnCDDraw.Checked == true && !File.Exists("ddraw.dll"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ddraw.dll", 
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ddraw.dll");
            }
            else if (this.chb_EnableCnCDDraw.Checked == false && File.Exists("ddraw.dll"))
            {
                File.Delete("ddraw.dll");
            }

            if (this.chb_EnableSmallInfantry.Checked == true && !File.Exists("smallinfantry.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "smallinfantry.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "smallinfantry.mix");
            }
            else if (this.chb_EnableSmallInfantry.Checked == false && File.Exists("smallinfantry.mix"))
            {
                File.Delete("smallinfantry.mix");
            }

            if (this.chb_UseLanPatch.Checked == true && !File.Exists("thipx32.dll"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "thipx32.dll",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "thipx32.dll");
            }
            else if (this.chb_UseLanPatch.Checked == false && File.Exists("thipx32.dll"))
            {
                File.Delete("thipx32.dll");
            }

            if (this.chb_EnableCounterstrike.Checked == true && !File.Exists("counterstrike.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "counterstrike.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "counterstrike.mix");
            }
            else if (this.chb_EnableCounterstrike.Checked == false && File.Exists("counterstrike.mix"))
            {
                File.Delete("counterstrike.mix");
            }

            if (this.chb_EnableAftermath.Checked == true && !File.Exists("aftermath.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "aftermath.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "aftermath.mixx");
            }
            else if (this.chb_EnableAftermath.Checked == false && File.Exists("aftermath.mix"))
            {
                File.Delete("aftermath.mix");
            }

            if (this.chb_ForceAftermathOnline.Checked == false && File.Exists("rules.ini"))
            {
                Crc32 crc32 = new Crc32();
                String hash = String.Empty;

                using (FileStream fs = File.Open("rules.ini", FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                if (hash == "c165ab92")
                {
                    File.Delete("rules.ini");
                }
            }

            if (this.chb_ForceAftermathOnlineFastBuildSpeed.Checked == false && File.Exists("rules.ini"))
            {
                Crc32 crc32 = new Crc32();
                String hash = String.Empty;

                using (FileStream fs = File.Open("rules.ini", FileMode.Open))
                    foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                if (hash == "adabee0b")
                {
                    File.Delete("rules.ini");
                }
            }

            if (this.chb_ForceAftermathOnline.Checked == true)
            {
                if (File.Exists("rules.ini"))
                {
                    Crc32 crc32 = new Crc32();
                    String hash = String.Empty;

                    using (FileStream fs = File.Open("rules.ini", FileMode.Open))
                        foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                    if (hash != "c165ab92")
                    {
                         // File exists but with different hash
                        MessageBox.Show("Force Aftermath expansion is enabled but another rules.ini file has been found, this file has been renamed to ___rules.ini.");

                        File.Move(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini",
                        Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "___rules.ini");

                        File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ForceAMrules.ini",
                        Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini");
                    }
                }
                else
                {
                    File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ForceAMrules.ini",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini");
                }              
            }

            if (this.chb_ForceAftermathOnlineFastBuildSpeed.Checked == true)
            {
                if (File.Exists("rules.ini"))
                {
                    Crc32 crc32 = new Crc32();
                    String hash = String.Empty;

                    using (FileStream fs = File.Open("rules.ini", FileMode.Open))
                        foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                    if (hash != "adabee0b")
                    {
                        // File exists but with different hash
                        MessageBox.Show("Force Aftermath with fast build speed expansion is enabled but another rules.ini file has been found, this file has been renamed to ___rules.ini.");

                        File.Move(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini",
                        Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "___rules.ini");

                        File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ForceAMRulesFastBuildSpeed.ini",
                        Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini");
                    }
                }
                else
                {
                    File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ForceAMRulesFastBuildSpeed.ini",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "rules.ini");
                }
            }

            Files.RedAlertINI.setIntValue("ConfigTool", "ConfigToolTab", this.tabControl1.SelectedIndex);

            double Brightness = ((double)this.slider_Brightness.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Brightness", Brightness.ToString());

            double Contrast = ((double)this.slider_Contrast.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Contrast", Contrast.ToString());

            double Color= ((double)this.slider_Color.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Color", Color.ToString());

            double Tint = ((double)this.slider_Tint.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Tint", Tint.ToString());

            KeysConverter Converter = new KeysConverter();

            Save_Hotkey_From_Row_Value("KeyForceMove1", 1);
            Save_Hotkey_From_Row_Value("KeyForceMove2", 2);
            Save_Hotkey_From_Row_Value("KeyForceAttack1", 3);
            Save_Hotkey_From_Row_Value("KeyForceAttack2", 4);
            Save_Hotkey_From_Row_Value("KeySelect1", 5);
            Save_Hotkey_From_Row_Value("KeySelect2", 6);
            Save_Hotkey_From_Row_Value("KeyScatter", 7);
            Save_Hotkey_From_Row_Value("KeyStop", 8);
            Save_Hotkey_From_Row_Value("KeyGuard", 9);
            Save_Hotkey_From_Row_Value("KeyNext", 10);
            Save_Hotkey_From_Row_Value("KeyPrevious", 11);
            Save_Hotkey_From_Row_Value("KeyFormation", 12);
            Save_Hotkey_From_Row_Value("KeyHome1", 13);
            Save_Hotkey_From_Row_Value("KeyHome2", 14);
            Save_Hotkey_From_Row_Value("KeyBase", 15);
            Save_Hotkey_From_Row_Value("KeyResign", 16);
            Save_Hotkey_From_Row_Value("KeyAlliance", 17);
            Save_Hotkey_From_Row_Value("KeyBookmark1", 18);
            Save_Hotkey_From_Row_Value("KeyBookmark2", 19);
            Save_Hotkey_From_Row_Value("KeyBookmark3", 20);
            Save_Hotkey_From_Row_Value("KeyBookmark4", 21);
            Save_Hotkey_From_Row_Value("KeySelectView", 22);
            Save_Hotkey_From_Row_Value("KeyRepairToggle", 23);
            Save_Hotkey_From_Row_Value("KeyRepairOn", 24);
            Save_Hotkey_From_Row_Value("KeyRepairOff", 25);
            Save_Hotkey_From_Row_Value("KeySellToggle", 26);
            Save_Hotkey_From_Row_Value("KeySellOn", 27);
            Save_Hotkey_From_Row_Value("KeySellOf", 28);
            Save_Hotkey_From_Row_Value("KeyMapToggle", 29);
            Save_Hotkey_From_Row_Value("KeySidebarUp", 30);
            Save_Hotkey_From_Row_Value("KeySidebarDown", 31);
            Save_Hotkey_From_Row_Value("KeyOption1", 32);
            Save_Hotkey_From_Row_Value("KeyOption2", 33);
            Save_Hotkey_From_Row_Value("KeyScrollLeft", 34);
            Save_Hotkey_From_Row_Value("KeyScrollRight", 35);
            Save_Hotkey_From_Row_Value("KeyScrollUp", 36);
            Save_Hotkey_From_Row_Value("KeyScrollDown", 37);
            Save_Hotkey_From_Row_Value("KeyQueueMove1", 38);
            Save_Hotkey_From_Row_Value("KeyQueueMove2", 39);
            Save_Hotkey_From_Row_Value("KeyTeam1", 40);
            Save_Hotkey_From_Row_Value("KeyTeam2", 41);
            Save_Hotkey_From_Row_Value("KeyTeam3", 42);
            Save_Hotkey_From_Row_Value("KeyTeam4", 43);
            Save_Hotkey_From_Row_Value("KeyTeam5", 44);
            Save_Hotkey_From_Row_Value("KeyTeam6", 45);
            Save_Hotkey_From_Row_Value("KeyTeam7", 46);
            Save_Hotkey_From_Row_Value("KeyTeam8", 47);
            Save_Hotkey_From_Row_Value("KeyTeam9", 48);
            Save_Hotkey_From_Row_Value("KeyTeam10", 49);


            Files.RedAlertINI.writeIni();
            Files.DDrawINI.writeIni();

            Application.Exit();
        }

        bool Is_64_Bit_OS()
        {
            if (IntPtr.Size == 8)
            {
                return true;
            }
            return false;
        }

//        void Apply_Colour_Registry_Fix()
//        {
//            string OSIs64Bit = Is_64_Bit_OS() ? "WoW6432Node" : "";
//            RegistryKey Ra95Reg = Registry.LocalMachine.CreateSubKey("SOFTWARE\\" + OSIs64Bit + "\\Microsoft\\DirectDraw\\Compatibility\\ra95");
//            
//           Ra95Reg.SetValue("Name", "ra95.exe", RegistryValueKind.String);
//           Ra95Reg.SetValue("ID", 0x36CB58CB, RegistryValueKind.DWord);
//           Ra95Reg.SetValue("Flags", new byte[] {00, 08, 00, 00 }/*00080000*/, RegistryValueKind.Binary);
//        }
//
//        void Enable_Win95_RA95_Compatibility_Mode()
//        {
//            RegistryKey Compat = Registry.LocalMachine.CreateSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers");
//            Compat.SetValue(Directory.GetCurrentDirectory() + "\\ra95.exe", "WIN95", RegistryValueKind.String);
//        }
//
//        void Disable_Win95_RA95_Compatibility_Mode()
//        {
//            RegistryKey Compat = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion\\AppCompatFlags\\Layers", true);
//            Compat.DeleteValue(Directory.GetCurrentDirectory() + "\\ra95.exe", false);        
//        }
//
//        void Remove_Colour_Registry_Fix()
//        {
//        }

        void Save_Hotkey_From_Row_Value(string HotKeyINIKey, int RowIndex)
        {
            KeysConverter Converter = new KeysConverter();

            Files.RedAlertINI.setIntValue("WinHotKeys", HotKeyINIKey,
                Convert.ToInt32((char)(Keys)Converter.ConvertFromString((string)this.grid_HotKeyEditor.Rows[RowIndex].Cells["ColumnHotkeyValue"].Value)));
        }

        void Set_Row_From_Hotkey_INI(string INIKey, int RowIndex)
        {
            grid_HotKeyEditor.Rows[RowIndex].Cells["ColumnHotkeyName"].Value = INIKey;

            this.grid_HotKeyEditor.Rows[RowIndex].Cells["ColumnHotkeyValue"].Value =
                ((Keys)Files.RedAlertINI.getIntValue("WinHotKeys", INIKey, 0)).ToString();
        }

        void Set_Row_Value(char ASCIIValue, int RowIndex)
        {
            this.grid_HotKeyEditor.Rows[RowIndex].Cells["ColumnHotkeyValue"].Value =
                ((Keys)ASCIIValue).ToString();
        }



        private void radiob_reso640x400_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_reso640x400.Checked == true)
            {
                this.radiob_reso640x480.Checked = false;
                this.radiob_reso800x600.Checked = false;
                this.radiob_reso1024x768.Checked = false;
                this.radiob_resoCustom.Checked = false;
            }
        }

        private void radiob_reso640x480_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_reso640x480.Checked == true)
            {
 //               this.radiob_reso640x400.Checked = false;
 //               this.radiob_reso800x600.Checked = false;
 //               this.radiob_reso1024x768.Checked = false;
 //               this.radiob_resoCustom.Checked = false;
            }
        }

        private void radiob_reso800x600_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiob_reso1024x768_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtb_resoCustomWidth_TextChanged(object sender, EventArgs e)
        {
/*            if (this.txtb_resoCustomWidth.Text.Length == 0)
            {
                this.txtb_resoCustomWidth.Text = "0";
            } */
            Update_Use_RA_Aspect_Ratio();
        }

        private void txtb_resoCustomHeight_TextChanged(object sender, EventArgs e)
        {
/*           if (this.txtb_resoCustomHeight.Text.Length == 0)
            {
                this.txtb_resoCustomHeight.Text = "0";
            } */
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_resoCustom_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.radiob_resoCustom.Checked == false)
            {
                this.txtb_resoCustomHeight.Enabled = false;
                this.txtb_resoCustomWidth.Enabled = false;
                this.but_DetectReso.Enabled = false;
            }
            else
            {
                this.txtb_resoCustomHeight.Enabled = true;
                this.txtb_resoCustomWidth.Enabled = true;
                this.but_DetectReso.Enabled = true;
            }
        }

        private void but_DetectReso_Click(object sender, EventArgs e)
        {
            Rectangle resolution = Screen.PrimaryScreen.Bounds;
            this.txtb_resoCustomWidth.Text = resolution.Width.ToString();
            this.txtb_resoCustomHeight.Text = resolution.Height.ToString();
        }

        private void radiob_reso640x400_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_reso640x480_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();

            if (this.radiob_reso640x480.Checked == true)
            {
                this.chb_StretchCustom.Checked = true;
                this.txtb_StretchCustomHeight.Text = "480";
                this.txtb_StretchCustomWidth.Text = "640";
                this.txtb_StretchCustomHeight.Enabled = true;
                this.txtb_StretchCustomWidth.Enabled = true;
            }
        }

        private void radiob_reso800x600_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void radiob_reso1024x768_CheckedChanged_1(object sender, EventArgs e)
        {
            Update_Use_RA_Aspect_Ratio();
        }

        private void chb_UseRAAspectRatio_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_UseRAAspectRatio.Checked == true)
            {
                this.chb_StretchCustom.Checked = false;
            }
        }

        private void chb_StretchCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_StretchCustom.Checked == true)
            {
                this.chb_UseRAAspectRatio.Checked = false;

                this.txtb_StretchCustomHeight.Enabled = true;
                this.txtb_StretchCustomWidth.Enabled = true;
            }
            else
            {
                this.txtb_StretchCustomHeight.Enabled = false;
                this.txtb_StretchCustomWidth.Enabled = false;
            }
        }

        private void chb_EnableCnCDDraw_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_EnableCnCDDraw.Checked == false)
            {
                this.chb_AllowHardwareFilledBits.Enabled = true;
                this.radiob_reso640x480.Enabled = false;
                this.radiob_reso640x480.Checked = false;

                this.txt_StretchingScaling.Visible = false;
                this.chb_UseRAAspectRatio.Visible = false;
                this.chb_StretchCustom.Visible = false;
                this.label18.Visible = false;
                this.txt_UseRAAspectRatio.Visible = false;
                this.txtb_StretchCustomHeight.Visible = false;
                this.txtb_StretchCustomWidth.Visible = false;
                this.label20.Visible = false;
                this.label21.Visible = false;
                this.cmbox_ScalingFilter.Visible = false;
                this.label24.Visible = false;
                this.radiob_RendererGDI.Visible = false;
                this.radiob_RendererOpenGL.Visible = false;
                this.chb_RunWindowed.Visible = false;
                this.chb_ShowWindowedBorder.Visible = false;
                this.chb_UseWindowBoxing.Visible = false;
                this.label34.Visible = false;
                this.label35.Visible = false;
                this.chb_AutoAdjustMouse.Visible = false;
                this.chb_EnableMouseHack.Visible = false;
                this.chb_EnableVSync.Visible = false;
                this.chb_ForceSingleCPU.Visible = false;
                this.label14.Visible = false;
                this.txtb_MaxFPS.Visible = false;
                this.label33.Visible = false;
                this.cmbox_BitsPerPixels.Visible = false;
                this.label25.Visible = false;
                this.label26.Visible = false;
                this.label31.Visible = false;
                this.label32.Visible = false;
                this.label29.Visible = false;
                this.label30.Visible = false;
                this.chb_VideoStretching.Visible = false;
            }
            else
            {
                this.chb_AllowHardwareFilledBits.Enabled = false;
                this.radiob_reso640x480.Enabled = true;

                this.chb_VideoStretching.Visible = true;
                this.txt_StretchingScaling.Visible = true;
                this.chb_UseRAAspectRatio.Visible = true;
                this.chb_StretchCustom.Visible = true;
                this.label18.Visible = true;
                this.txt_UseRAAspectRatio.Visible = true;
                this.txtb_StretchCustomHeight.Visible = true;
                this.txtb_StretchCustomWidth.Visible = true;
                this.label20.Visible = true;
                this.label21.Visible = true;
                this.cmbox_ScalingFilter.Visible = true;
                this.label24.Visible = true;
                this.radiob_RendererGDI.Visible = true;
                this.radiob_RendererOpenGL.Visible = true;
                this.chb_RunWindowed.Visible = true;
                this.chb_ShowWindowedBorder.Visible = true;
                this.chb_UseWindowBoxing.Visible = true;
                this.label34.Visible = true;
                this.label35.Visible = true;
                this.chb_AutoAdjustMouse.Visible = true;
                this.chb_EnableMouseHack.Visible = true;
                this.chb_EnableVSync.Visible = true;
                this.chb_ForceSingleCPU.Visible = true;
                this.label14.Visible = true;
                this.txtb_MaxFPS.Visible = true;
                this.label33.Visible = true;
                this.cmbox_BitsPerPixels.Visible = true;
                this.label25.Visible = true;
                this.label26.Visible = true;
                this.label31.Visible = true;
                this.label32.Visible = true;
                this.label29.Visible = true;
                this.label30.Visible = true;
            }
        }

        private void radiob_RendererGDI_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_RendererGDI.Checked == true)
            {
                this.chb_UseWindowBoxing.Enabled = true;
                this.label34.Enabled = true;
                this.label35.Enabled = true;
            }
            else
            {
                this.chb_UseWindowBoxing.Enabled = false;
                this.chb_UseWindowBoxing.Checked = false;
                this.label34.Enabled = false;
                this.label35.Enabled = false;
            }
        }

        private void radiob_RendererOpenGL_CheckedChanged(object sender, EventArgs e)
        {
            if (this.radiob_RendererOpenGL.Checked == true)
            {
                this.chb_EnableVSync.Enabled = true;

                this.cmbox_ScalingFilter.Enabled = true;
            }
            else
            {
                this.chb_EnableVSync.Enabled = false;
                this.chb_EnableVSync.Checked = false;

                this.cmbox_ScalingFilter.Enabled = false;
                // this.cmbox_ScalingFilter.SelectedIndex = -1;
            }
        }

        private void chb_EnableAftermath_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_EnableAftermath.Checked == false)
            {
                this.chb_ForceAftermathOnline.Checked = false;
                this.chb_ForceAftermathOnline.Enabled = false;
                this.chb_ForceAftermathOnlineFastBuildSpeed.Checked = false;
                this.chb_ForceAftermathOnlineFastBuildSpeed.Enabled = false;
            }
            else
            {
                this.chb_ForceAftermathOnline.Enabled = true;
                this.chb_ForceAftermathOnlineFastBuildSpeed.Enabled = true;
            }
        }

        private void but_ResetVisualOptions_Click(object sender, EventArgs e)
        {
            this.slider_Brightness.Value = 500;
            this.slider_Color.Value = 500;
            this.slider_Tint.Value = 500;
            this.slider_Contrast.Value = 500;
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
        }

        private void HotkeyEditorCell_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (this.grid_HotKeyEditor.CurrentCell.ColumnIndex == 1)
            {
//                MessageBox.Show(((int)e.KeyChar).ToString());
//                MessageBox.Show(e.KeyChar.ToString());

                grid_HotKeyEditor.Select();

                grid_HotKeyEditor.EndEdit();
            }


        }

        private void Hotkey_Editor_Editing_Control_Showing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (this.grid_HotKeyEditor.CurrentCell.ColumnIndex == 0)
            {
                grid_HotKeyEditor.Select();
                grid_HotKeyEditor.EndEdit();
            }
            // Ensure that the editing control is a TextBox
            TextBox txt = e.Control as TextBox;
            if (txt != null && this.grid_HotKeyEditor.CurrentCell.ColumnIndex == 1)
            {
                // Remove an existing event handler, if present, to avoid adding
                // multiple handler when the editing control is reused
                txt.KeyPress -= new KeyPressEventHandler(HotkeyEditorCell_KeyPress);

                // Add a handler for the TextBox's KeyPress event
                txt.KeyPress += new KeyPressEventHandler(HotkeyEditorCell_KeyPress);
            }
        }

        private void OnMouseClick(object sender, EventArgs e)
        {

        }

        private void Key_Down_Test(object sender, KeyEventArgs e)
        {
            if (this.grid_HotKeyEditor.CurrentCell == null) return;
            char a = (char)e.KeyCode;
//            MessageBox.Show(a.ToString());
            Keys test = (Keys)a;
//            MessageBox.Show(test.ToString());
//            MessageBox.Show(e.KeyCode.ToString() + " "
//        + Convert.ToInt32(StringToASCII[e.KeyCode.ToString()]).ToString() );

            if (this.grid_HotKeyEditor.CurrentCell.ColumnIndex == 1)
            {
                this.grid_HotKeyEditor.CurrentCell.Value = e.KeyCode.ToString();
            }
        }

        private void but_ClearSelectedKey_Click(object sender, EventArgs e)
        {
            if (grid_HotKeyEditor.CurrentCell != null && grid_HotKeyEditor.CurrentCell.ColumnIndex == 1)
            {
                grid_HotKeyEditor.CurrentCell.Value = "None";
            }          
        }

        private void but_ResetDefaults_Click(object sender, EventArgs e)
        {
            Set_Row_Value((char)18, 1);
            Set_Row_Value((char)18, 2);
            Set_Row_Value((char)17, 3);
            Set_Row_Value((char)17, 4);
            Set_Row_Value((char)16, 5);
            Set_Row_Value((char)16, 6);
            Set_Row_Value((char)88, 7);
            Set_Row_Value((char)83, 8);
            Set_Row_Value((char)71, 9);
            Set_Row_Value((char)78, 10);
            Set_Row_Value((char)66, 11);
            Set_Row_Value((char)70, 12);
            Set_Row_Value((char)36, 13);
            Set_Row_Value((char)103, 14);
            Set_Row_Value((char)72, 15);
            Set_Row_Value((char)82, 16);
            Set_Row_Value((char)65, 17);
            Set_Row_Value((char)120, 18);
            Set_Row_Value((char)121, 19);
            Set_Row_Value((char)122, 20);
            Set_Row_Value((char)123, 21);
            Set_Row_Value((char)69, 22);
            Set_Row_Value((char)84, 23);
            Set_Row_Value((char)0, 24);
            Set_Row_Value((char)0, 25);
            Set_Row_Value((char)89, 26);
            Set_Row_Value((char)0, 27);
            Set_Row_Value((char)0, 28);
            Set_Row_Value((char)85, 29);
            Set_Row_Value((char)38, 30);
            Set_Row_Value((char)40, 31);
            Set_Row_Value((char)27, 32);
            Set_Row_Value((char)32, 33);
            Set_Row_Value((char)0, 34);
            Set_Row_Value((char)0, 35);
            Set_Row_Value((char)0, 36);
            Set_Row_Value((char)0, 37);
            Set_Row_Value((char)81, 38);
            Set_Row_Value((char)81, 39);
            Set_Row_Value((char)49, 40);
            Set_Row_Value((char)50, 41);
            Set_Row_Value((char)51, 42);
            Set_Row_Value((char)52, 43);
            Set_Row_Value((char)53, 44);
            Set_Row_Value((char)54, 45);
            Set_Row_Value((char)55, 46);
            Set_Row_Value((char)56, 47);
            Set_Row_Value((char)57, 48);
            Set_Row_Value((char)48, 49);
        }

        private void But_UseProSetup_Click(object sender, EventArgs e)
        {
            Set_Row_Value((char)18, 1);
            Set_Row_Value((char)18, 2);
            Set_Row_Value((char)17, 3);
            Set_Row_Value((char)17, 4);
            Set_Row_Value((char)16, 5);
            Set_Row_Value((char)16, 6);
            Set_Row_Value((char)88, 7);
            Set_Row_Value((char)83, 8);
            Set_Row_Value((char)71, 9);
            Set_Row_Value((char)78, 10);
            Set_Row_Value((char)66, 11);
            Set_Row_Value((char)67, 12);
            Set_Row_Value((char)36, 13);
            Set_Row_Value((char)103, 14);
            Set_Row_Value((char)72, 15);
            Set_Row_Value((char)82, 16);
            Set_Row_Value((char)65, 17);
            Set_Row_Value((char)120, 18);
            Set_Row_Value((char)32, 19);
            Set_Row_Value((char)82, 20);
            Set_Row_Value((char)87, 21);
            Set_Row_Value((char)69, 22);
            Set_Row_Value((char)84, 23);
            Set_Row_Value((char)0, 24);
            Set_Row_Value((char)0, 25);
            Set_Row_Value((char)89, 26);
            Set_Row_Value((char)0, 27);
            Set_Row_Value((char)0, 28);
            Set_Row_Value((char)86, 29);
            Set_Row_Value((char)68, 30);
            Set_Row_Value((char)70, 31);
            Set_Row_Value((char)27, 32);
            Set_Row_Value((char)0, 33);
            Set_Row_Value((char)37, 34);
            Set_Row_Value((char)39, 35);
            Set_Row_Value((char)38, 36);
            Set_Row_Value((char)40, 37);
            Set_Row_Value((char)81, 38);
            Set_Row_Value((char)81, 39);
            Set_Row_Value((char)49, 40);
            Set_Row_Value((char)50, 41);
            Set_Row_Value((char)51, 42);
            Set_Row_Value((char)52, 43);
            Set_Row_Value((char)53, 44);
            Set_Row_Value((char)54, 45);
            Set_Row_Value((char)55, 46);
            Set_Row_Value((char)56, 47);
            Set_Row_Value((char)57, 48);
            Set_Row_Value((char)48, 49);
        }

        private void link_AboutProjectHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iran/RedAlertConfig");
        }

        private void link_AboutCnCNet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.cncnet.org");
        }

        private void link_AboutCnCDDaw_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://hifi.iki.fi/cnc-ddraw/");
        }

        private void link_Aboutv033p3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Iran/ra303p-iran");
        }

        private void chb_ForceAftermathOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_ForceAftermathOnline.Checked == true)
            {
                this.chb_ForceAftermathOnlineFastBuildSpeed.Checked = false;
            }
        }

        private void chb_ForceAftermathOnlineFastBuildSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_ForceAftermathOnlineFastBuildSpeed.Checked == true)
            {
                this.chb_ForceAftermathOnline.Checked = false;
            }
        }

        private void cmbox_UnitCount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
