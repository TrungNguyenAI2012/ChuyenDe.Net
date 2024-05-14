
namespace GUI
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnTime = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnAnother = new System.Windows.Forms.Button();
            this.btnHealth = new System.Windows.Forms.Button();
            this.btnManager = new System.Windows.Forms.Button();
            this.btnGanttChart = new System.Windows.Forms.Button();
            this.btnPomodoro = new System.Windows.Forms.Button();
            this.btnMindMap = new System.Windows.Forms.Button();
            this.btnJob = new System.Windows.Forms.Button();
            this.btnDiary = new System.Windows.Forms.Button();
            this.btnNote = new System.Windows.Forms.Button();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnEvent = new System.Windows.Forms.Button();
            this.btnTimer = new System.Windows.Forms.Button();
            this.btnTimeTable = new System.Windows.Forms.Button();
            this.ttpMain = new System.Windows.Forms.ToolTip(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.btnLife = new System.Windows.Forms.Button();
            this.pbxTime = new System.Windows.Forms.PictureBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTime)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTime
            // 
            resources.ApplyResources(this.btnTime, "btnTime");
            this.btnTime.BackColor = System.Drawing.Color.Yellow;
            this.btnTime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTime.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTime.FlatAppearance.BorderSize = 3;
            this.btnTime.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnTime.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTime.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTime.Name = "btnTime";
            this.ttpMain.SetToolTip(this.btnTime, resources.GetString("btnTime.ToolTip"));
            this.btnTime.UseVisualStyleBackColor = false;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // btnMoney
            // 
            resources.ApplyResources(this.btnMoney, "btnMoney");
            this.btnMoney.BackColor = System.Drawing.Color.Blue;
            this.btnMoney.BackgroundImage = global::GUI.Properties.Resources.Money;
            this.btnMoney.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMoney.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMoney.FlatAppearance.BorderSize = 3;
            this.btnMoney.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnMoney.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMoney.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMoney.ForeColor = System.Drawing.Color.White;
            this.btnMoney.Name = "btnMoney";
            this.ttpMain.SetToolTip(this.btnMoney, resources.GetString("btnMoney.ToolTip"));
            this.btnMoney.UseVisualStyleBackColor = false;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnAnother
            // 
            resources.ApplyResources(this.btnAnother, "btnAnother");
            this.btnAnother.BackColor = System.Drawing.Color.Blue;
            this.btnAnother.BackgroundImage = global::GUI.Properties.Resources.Another;
            this.btnAnother.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnother.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAnother.FlatAppearance.BorderSize = 3;
            this.btnAnother.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAnother.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAnother.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnother.ForeColor = System.Drawing.Color.White;
            this.btnAnother.Name = "btnAnother";
            this.ttpMain.SetToolTip(this.btnAnother, resources.GetString("btnAnother.ToolTip"));
            this.btnAnother.UseVisualStyleBackColor = false;
            this.btnAnother.Click += new System.EventHandler(this.btnAnother_Click);
            // 
            // btnHealth
            // 
            resources.ApplyResources(this.btnHealth, "btnHealth");
            this.btnHealth.BackColor = System.Drawing.Color.Blue;
            this.btnHealth.BackgroundImage = global::GUI.Properties.Resources.Health;
            this.btnHealth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHealth.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnHealth.FlatAppearance.BorderSize = 3;
            this.btnHealth.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnHealth.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHealth.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHealth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHealth.Name = "btnHealth";
            this.ttpMain.SetToolTip(this.btnHealth, resources.GetString("btnHealth.ToolTip"));
            this.btnHealth.UseVisualStyleBackColor = false;
            this.btnHealth.Click += new System.EventHandler(this.btnHealth_Click);
            // 
            // btnManager
            // 
            resources.ApplyResources(this.btnManager, "btnManager");
            this.btnManager.BackColor = System.Drawing.Color.Blue;
            this.btnManager.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManager.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnManager.FlatAppearance.BorderSize = 3;
            this.btnManager.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnManager.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnManager.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnManager.ForeColor = System.Drawing.SystemColors.Control;
            this.btnManager.Name = "btnManager";
            this.ttpMain.SetToolTip(this.btnManager, resources.GetString("btnManager.ToolTip"));
            this.btnManager.UseVisualStyleBackColor = false;
            this.btnManager.Click += new System.EventHandler(this.btnManager_Click);
            // 
            // btnGanttChart
            // 
            resources.ApplyResources(this.btnGanttChart, "btnGanttChart");
            this.btnGanttChart.BackColor = System.Drawing.Color.Purple;
            this.btnGanttChart.BackgroundImage = global::GUI.Properties.Resources.GanttChart;
            this.btnGanttChart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGanttChart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnGanttChart.FlatAppearance.BorderSize = 3;
            this.btnGanttChart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnGanttChart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnGanttChart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnGanttChart.ForeColor = System.Drawing.Color.White;
            this.btnGanttChart.Name = "btnGanttChart";
            this.ttpMain.SetToolTip(this.btnGanttChart, resources.GetString("btnGanttChart.ToolTip"));
            this.btnGanttChart.UseVisualStyleBackColor = false;
            this.btnGanttChart.Click += new System.EventHandler(this.btnGanttChart_Click);
            // 
            // btnPomodoro
            // 
            resources.ApplyResources(this.btnPomodoro, "btnPomodoro");
            this.btnPomodoro.BackColor = System.Drawing.Color.Purple;
            this.btnPomodoro.BackgroundImage = global::GUI.Properties.Resources.Pomodoro;
            this.btnPomodoro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPomodoro.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnPomodoro.FlatAppearance.BorderSize = 3;
            this.btnPomodoro.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnPomodoro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnPomodoro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPomodoro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPomodoro.Name = "btnPomodoro";
            this.ttpMain.SetToolTip(this.btnPomodoro, resources.GetString("btnPomodoro.ToolTip"));
            this.btnPomodoro.UseVisualStyleBackColor = false;
            this.btnPomodoro.Click += new System.EventHandler(this.btnPomodoro_Click);
            // 
            // btnMindMap
            // 
            resources.ApplyResources(this.btnMindMap, "btnMindMap");
            this.btnMindMap.BackColor = System.Drawing.Color.Purple;
            this.btnMindMap.BackgroundImage = global::GUI.Properties.Resources.MindMap;
            this.btnMindMap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMindMap.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnMindMap.FlatAppearance.BorderSize = 3;
            this.btnMindMap.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnMindMap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMindMap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMindMap.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMindMap.Name = "btnMindMap";
            this.ttpMain.SetToolTip(this.btnMindMap, resources.GetString("btnMindMap.ToolTip"));
            this.btnMindMap.UseVisualStyleBackColor = false;
            this.btnMindMap.Click += new System.EventHandler(this.btnMindMap_Click);
            // 
            // btnJob
            // 
            resources.ApplyResources(this.btnJob, "btnJob");
            this.btnJob.BackColor = System.Drawing.Color.Purple;
            this.btnJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJob.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnJob.FlatAppearance.BorderSize = 3;
            this.btnJob.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnJob.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnJob.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnJob.ForeColor = System.Drawing.SystemColors.Control;
            this.btnJob.Name = "btnJob";
            this.ttpMain.SetToolTip(this.btnJob, resources.GetString("btnJob.ToolTip"));
            this.btnJob.UseVisualStyleBackColor = false;
            this.btnJob.Click += new System.EventHandler(this.btnJob_Click);
            // 
            // btnDiary
            // 
            resources.ApplyResources(this.btnDiary, "btnDiary");
            this.btnDiary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnDiary.BackgroundImage = global::GUI.Properties.Resources.Dairy;
            this.btnDiary.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDiary.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnDiary.FlatAppearance.BorderSize = 3;
            this.btnDiary.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnDiary.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDiary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDiary.ForeColor = System.Drawing.Color.Azure;
            this.btnDiary.Name = "btnDiary";
            this.ttpMain.SetToolTip(this.btnDiary, resources.GetString("btnDiary.ToolTip"));
            this.btnDiary.UseVisualStyleBackColor = false;
            this.btnDiary.Click += new System.EventHandler(this.btnDiary_Click);
            // 
            // btnNote
            // 
            resources.ApplyResources(this.btnNote, "btnNote");
            this.btnNote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnNote.BackgroundImage = global::GUI.Properties.Resources.Note;
            this.btnNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNote.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnNote.FlatAppearance.BorderSize = 3;
            this.btnNote.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnNote.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNote.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNote.ForeColor = System.Drawing.Color.White;
            this.btnNote.Name = "btnNote";
            this.ttpMain.SetToolTip(this.btnNote, resources.GetString("btnNote.ToolTip"));
            this.btnNote.UseVisualStyleBackColor = false;
            this.btnNote.Click += new System.EventHandler(this.btnNote_Click);
            // 
            // btnAlarm
            // 
            resources.ApplyResources(this.btnAlarm, "btnAlarm");
            this.btnAlarm.BackColor = System.Drawing.Color.Yellow;
            this.btnAlarm.BackgroundImage = global::GUI.Properties.Resources.Alarm;
            this.btnAlarm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlarm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAlarm.FlatAppearance.BorderSize = 3;
            this.btnAlarm.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnAlarm.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAlarm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAlarm.ForeColor = System.Drawing.Color.Black;
            this.btnAlarm.Name = "btnAlarm";
            this.ttpMain.SetToolTip(this.btnAlarm, resources.GetString("btnAlarm.ToolTip"));
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnEvent
            // 
            resources.ApplyResources(this.btnEvent, "btnEvent");
            this.btnEvent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEvent.BackgroundImage = global::GUI.Properties.Resources.Event;
            this.btnEvent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEvent.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnEvent.FlatAppearance.BorderSize = 3;
            this.btnEvent.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnEvent.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnEvent.ForeColor = System.Drawing.Color.Black;
            this.btnEvent.Name = "btnEvent";
            this.ttpMain.SetToolTip(this.btnEvent, resources.GetString("btnEvent.ToolTip"));
            this.btnEvent.UseVisualStyleBackColor = false;
            this.btnEvent.Click += new System.EventHandler(this.btnEvent_Click);
            // 
            // btnTimer
            // 
            resources.ApplyResources(this.btnTimer, "btnTimer");
            this.btnTimer.BackColor = System.Drawing.Color.Yellow;
            this.btnTimer.BackgroundImage = global::GUI.Properties.Resources.Timer;
            this.btnTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimer.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimer.FlatAppearance.BorderSize = 3;
            this.btnTimer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnTimer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimer.ForeColor = System.Drawing.Color.White;
            this.btnTimer.Name = "btnTimer";
            this.ttpMain.SetToolTip(this.btnTimer, resources.GetString("btnTimer.ToolTip"));
            this.btnTimer.UseVisualStyleBackColor = false;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // btnTimeTable
            // 
            resources.ApplyResources(this.btnTimeTable, "btnTimeTable");
            this.btnTimeTable.BackColor = System.Drawing.Color.Yellow;
            this.btnTimeTable.BackgroundImage = global::GUI.Properties.Resources.TimeTable;
            this.btnTimeTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimeTable.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnTimeTable.FlatAppearance.BorderSize = 3;
            this.btnTimeTable.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnTimeTable.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnTimeTable.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnTimeTable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnTimeTable.Name = "btnTimeTable";
            this.ttpMain.SetToolTip(this.btnTimeTable, resources.GetString("btnTimeTable.ToolTip"));
            this.btnTimeTable.UseVisualStyleBackColor = false;
            this.btnTimeTable.Click += new System.EventHandler(this.btnTimeTable_Click);
            // 
            // ttpMain
            // 
            this.ttpMain.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ttpMain.ShowAlways = true;
            this.ttpMain.ToolTipTitle = "Tóm tắt";
            // 
            // btnStart
            // 
            resources.ApplyResources(this.btnStart, "btnStart");
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.BorderSize = 3;
            this.btnStart.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnStart.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStart.Name = "btnStart";
            this.ttpMain.SetToolTip(this.btnStart, resources.GetString("btnStart.ToolTip"));
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnLife
            // 
            resources.ApplyResources(this.btnLife, "btnLife");
            this.btnLife.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLife.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLife.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnLife.FlatAppearance.BorderSize = 3;
            this.btnLife.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.btnLife.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnLife.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLife.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLife.Name = "btnLife";
            this.ttpMain.SetToolTip(this.btnLife, resources.GetString("btnLife.ToolTip"));
            this.btnLife.UseVisualStyleBackColor = false;
            this.btnLife.Click += new System.EventHandler(this.btnLife_Click);
            // 
            // pbxTime
            // 
            this.pbxTime.BackColor = System.Drawing.SystemColors.Control;
            this.pbxTime.BackgroundImage = global::GUI.Properties.Resources.LoadBackGround;
            resources.ApplyResources(this.pbxTime, "pbxTime");
            this.pbxTime.Image = global::GUI.Properties.Resources.Load;
            this.pbxTime.Name = "pbxTime";
            this.pbxTime.TabStop = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Interval = 1000;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.pbxTime);
            this.Controls.Add(this.btnLife);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnManager);
            this.Controls.Add(this.btnHealth);
            this.Controls.Add(this.btnAnother);
            this.Controls.Add(this.btnMoney);
            this.Controls.Add(this.btnJob);
            this.Controls.Add(this.btnMindMap);
            this.Controls.Add(this.btnPomodoro);
            this.Controls.Add(this.btnGanttChart);
            this.Controls.Add(this.btnTimeTable);
            this.Controls.Add(this.btnNote);
            this.Controls.Add(this.btnDiary);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.btnEvent);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTime)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button btnMoney;
        private System.Windows.Forms.Button btnAnother;
        private System.Windows.Forms.Button btnHealth;
        private System.Windows.Forms.Button btnManager;
        private System.Windows.Forms.Button btnGanttChart;
        private System.Windows.Forms.Button btnPomodoro;
        private System.Windows.Forms.Button btnMindMap;
        private System.Windows.Forms.Button btnJob;
        private System.Windows.Forms.Button btnDiary;
        private System.Windows.Forms.Button btnNote;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnEvent;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Button btnTimeTable;
        private System.Windows.Forms.ToolTip ttpMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnLife;
        private System.Windows.Forms.PictureBox pbxTime;
        private System.Windows.Forms.Timer tmrMain;
    }
}

