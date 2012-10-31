using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
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
           if (File.Exists("ddraw.dll") == true)
           {
                this.chb_EnableCnCDDraw.Checked = true;
           }
           else
           {
               this.chb_EnableCnCDDraw.Checked = false;
               chb_EnableCnCDDraw_CheckedChanged(this, null);
           }

           if (File.Exists("hires1.mix") == true)
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

           if (File.Exists("expand.mix") == true)
           {
               this.chb_EnableCounterstrike.Checked = true;
           }
           else
           {
               this.chb_EnableCounterstrike.Checked = false;
           }

           if (File.Exists("expand2.mix") == true)
           {
               this.chb_EnableAftermath.Checked = true;
           }
           else
           {
               this.chb_EnableAftermath.Checked = false;
               this.chb_ForceAftermathOnline.Checked = false;
               this.chb_ForceAftermathOnline.Enabled = false;
           }


           if (File.Exists("rules.ini") == true)
           {
                Crc32 crc32 = new Crc32();
                String hash = String.Empty;

                using (FileStream fs = File.Open("rules.ini", FileMode.Open))
    	        foreach (byte b in crc32.ComputeHash(fs)) hash += b.ToString("x2").ToLower();

                if (hash == "c165ab92")
                {
                    this.chb_ForceAftermathOnline.Checked = true;
                }
           }
           else
           {
               this.chb_ForceAftermathOnline.Checked = false;
           }

           if (Files.RedAlertINI.getBoolValue("Options", "UseRAAspectRatio", false) == true)
           {
               ResoWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
               ResoHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);
           }
           else
           {
               ResoWidth = Files.RedAlertINI.getIntValue("Options", "Width", 640);
               ResoHeight = Files.RedAlertINI.getIntValue("Options", "Height", 480);
           }

           this.txtb_resoCustomHeight.Enabled = false;
           this.txtb_resoCustomWidth.Enabled = false;
           this.but_DetectReso.Enabled = false;

           this.txtb_resoCustomHeight.Text = ResoHeight.ToString();
           this.txtb_resoCustomWidth.Text = ResoWidth.ToString();

            if (ResoWidth == 640 && ResoHeight == 400)
            {
                this.radiob_reso640x400.Checked = true;
            }
            else if (ResoWidth == 640 && ResoHeight == 480)
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

            this.txtb_StretchCustomWidth.Enabled = false;
            this.txtb_StretchCustomHeight.Enabled = false;
            
            int StretchWidth = Files.DDrawINI.getIntValue("ddraw", "width", 0);
            int StretchHeight = Files.DDrawINI.getIntValue("ddraw", "height", 0);

            this.txtb_StretchCustomWidth.Text = StretchWidth.ToString();
            this.txtb_StretchCustomHeight.Text = StretchHeight.ToString();

            if (this.txtb_StretchCustomWidth.Text == "0") this.txtb_StretchCustomWidth.Text = "";
            if (this.txtb_StretchCustomHeight.Text == "0") this.txtb_StretchCustomHeight.Text = "";

            txtb_Handle.Text = Files.RedAlertINI.getStringValue("Multiplayer", "Handle", "");

            if (Files.RedAlertINI.getBoolValue("Intro", "PlayIntro", false) == true)
            {
                chb_PlayIntro.Checked = true;
            }

            if (!File.Exists("movies1.mix") && !File.Exists("movies2.mix"))
            {
                chb_PlayIntro.Enabled = false;
                chb_PlayIntro.Text = "Play intro cinematic (requires movie files)";
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
            if (Files.RedAlertINI.getBoolValue("Options", "PaletteScroll", false) == true)
            {
                this.chb_PaletteScroll.Checked = true;
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

            this.cmbox_Side.SelectedIndex = Files.RedAlertINI.getIntValue("MultiPlayer", "Side", 2)-2;

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

            if (Files.RedAlertINI.getBoolValue("Options", "UseRAAspectRatio", false) == true)
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
            this.cmbox_BitsPerPixels.SelectedIndex = BPP;

            this.tabControl1.SelectedIndex = Files.RedAlertINI.getIntValue("Options", "ConfigToolTab", 0);
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

            if (this.radiob_reso640x400.Checked== true)
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

            this.grid_HotKeyEditor.Rows.Add();

            grid_HotKeyEditor.Rows[0].Cells["ColumnHotkeyName"].Value = "herp";
            grid_HotKeyEditor.Rows[0].Cells["ColumnHotkeyValue"].Value = "derp";

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

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
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
                Files.RedAlertINI.setBoolValue("Options", "UseRAAspectRatio", false);
            }

            if (this.radiob_reso640x400.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 400);
            }
            else if (this.radiob_reso640x480.Checked == true)
            {
                Files.RedAlertINI.setIntValue("Options", "Width", 640);
                Files.RedAlertINI.setIntValue("Options", "Height", 480);
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
                Files.RedAlertINI.setBoolValue("Options", "UseRAAspectRatio", false);
            }
            if (this.chb_UseRAAspectRatio.Checked == true)
            {
                int RAHeight = Files.RedAlertINI.getIntValue("Options", "Height", 0);
                Files.DDrawINI.setIntValue("ddraw", "height", RAHeight);
                Files.RedAlertINI.setIntValue("Options", "Height", (int)(RAHeight / 1.2));

                Files.RedAlertINI.setBoolValue("Options", "UseRAAspectRatio", true);

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

            Files.RedAlertINI.setStringValue("Multiplayer", "Handle", txtb_Handle.Text);

            if (chb_PlayIntro.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Intro", "PlayIntro", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Intro", "PlayIntro", false);
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

            if (this.chb_PaletteScroll.Checked == true)
            {
                Files.RedAlertINI.setBoolValue("Options", "PaletteScroll", true);
            }
            else
            {
                Files.RedAlertINI.setBoolValue("Options", "PaletteScroll", false);
            }

            double Volume = ((double)this.slider_SoundVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Volume", Volume.ToString());

            double MusicVolume = ((double)this.Slider_MusicVolume.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "ScoreVolume", MusicVolume.ToString());
            Files.RedAlertINI.setStringValue("Options", "MultiplayerScoreVolume", MusicVolume.ToString());

            int GameSpeed = 6 - this.slider_GameSpeed.Value;
            Files.RedAlertINI.setIntValue("Options", "GameSpeed", GameSpeed);

            int ScrollRate = 6 - this.slider_ScrollRate.Value;
            Files.RedAlertINI.setIntValue("Options", "ScrollRate", ScrollRate);

            Files.RedAlertINI.setIntValue("MultiPlayer", "Side", this.cmbox_Side.SelectedIndex + 2);

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

            int MaxFPS;
            if (Int32.TryParse(this.txtb_MaxFPS.Text, out MaxFPS) == false)
            {
                MaxFPS = 0;
            }
            Files.DDrawINI.setIntValue("ddraw", "maxfps", MaxFPS);

            int BPP = this.cmbox_BitsPerPixels.SelectedIndex;
            Files.DDrawINI.setIntValue("ddraw", "bpp", BPP);

            if (this.chb_EnableCnCDDraw.Checked == true && !File.Exists("ddraw.dll"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "ddraw.dll", 
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ddraw.dll");
            }
            else if (this.chb_EnableCnCDDraw.Checked == false && File.Exists("ddraw.dll"))
            {
                File.Delete("ddraw.dll");
            }

            if (this.chb_EnableSmallInfantry.Checked == true && !File.Exists("hires1.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "hires1.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "hires1.mix");
            }
            else if (this.chb_EnableSmallInfantry.Checked == false && File.Exists("hires1.mix"))
            {
                File.Delete("hires1.mix");
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

            if (this.chb_EnableCounterstrike.Checked == true && !File.Exists("expand.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "expand.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "expand.mix");
            }
            else if (this.chb_EnableCounterstrike.Checked == false && File.Exists("expand.mix"))
            {
                File.Delete("expand.mix");
            }

            if (this.chb_EnableAftermath.Checked == true && !File.Exists("expand2.mix"))
            {
                File.Copy(Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "ConfigToolFiles" + Path.DirectorySeparatorChar + "expand2.mix",
                    Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar + "expand2.mix");
            }
            else if (this.chb_EnableAftermath.Checked == false && File.Exists("expand2.mix"))
            {
                File.Delete("expand2.mix");
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
            else if (this.chb_ForceAftermathOnline.Checked == false && File.Exists("rules.ini"))
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

            Files.RedAlertINI.setIntValue("Options", "ConfigToolTab", this.tabControl1.SelectedIndex);

            double Brightness = ((double)this.slider_Brightness.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Brightness", Brightness.ToString());

            double Contrast = ((double)this.slider_Contrast.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Contrast", Contrast.ToString());

            double Color= ((double)this.slider_Color.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Color", Color.ToString());

            double Tint = ((double)this.slider_Tint.Value) / 1000;
            Files.RedAlertINI.setStringValue("Options", "Tint", Tint.ToString());

            Files.RedAlertINI.writeIni();
            Files.DDrawINI.writeIni();

            Application.Exit();
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
            }
            else
            {
                this.chb_AllowHardwareFilledBits.Enabled = false;

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
            }
            else
            {
                this.chb_UseWindowBoxing.Enabled = false;
                this.chb_UseWindowBoxing.Checked = false;
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
                this.cmbox_ScalingFilter.SelectedIndex = -1;
            }
        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            this.grid_HotKeyEditor.BeginEdit(true);
        }

        private void chb_EnableAftermath_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chb_EnableAftermath.Checked == false)
            {
                this.chb_ForceAftermathOnline.Checked = false;
                this.chb_ForceAftermathOnline.Enabled = false;
            }
            else
            {
                this.chb_ForceAftermathOnline.Enabled = true;
            }
        }

        private void but_ResetVisualOptions_Click(object sender, EventArgs e)
        {
            this.slider_Brightness.Value = 500;
            this.slider_Color.Value = 500;
            this.slider_Tint.Value = 500;
            this.slider_Contrast.Value = 500;
        }
    }
}
