
namespace Calculadora_ProgramacionOrientadaAObjeto_Tarea
{
    partial class Index
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Exit_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Form_elipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.Minimize_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Form_drag = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TitleForm_lbl = new System.Windows.Forms.Label();
            this.Button1_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button2_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button3_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button4_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button5_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button6_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button7_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button8_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button9_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Button0_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonDot_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.ButtonCE_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Plus_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Minus_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Multi_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.Divide_btn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.PanelNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(188)))), ((int)(((byte)(214)))));
            this.TopPanel.Controls.Add(this.TitleForm_lbl);
            this.TopPanel.Controls.Add(this.Minimize_btn);
            this.TopPanel.Controls.Add(this.Exit_btn);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(277, 41);
            this.TopPanel.TabIndex = 0;
            // 
            // Exit_btn
            // 
            this.Exit_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exit_btn.CheckedState.Parent = this.Exit_btn;
            this.Exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_btn.CustomImages.Parent = this.Exit_btn;
            this.Exit_btn.FillColor = System.Drawing.Color.Crimson;
            this.Exit_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Exit_btn.ForeColor = System.Drawing.Color.White;
            this.Exit_btn.HoverState.Parent = this.Exit_btn;
            this.Exit_btn.Location = new System.Drawing.Point(246, 10);
            this.Exit_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Exit_btn.ShadowDecoration.Parent = this.Exit_btn;
            this.Exit_btn.Size = new System.Drawing.Size(19, 19);
            this.Exit_btn.TabIndex = 1;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // Form_elipse
            // 
            this.Form_elipse.BorderRadius = 20;
            this.Form_elipse.TargetControl = this;
            // 
            // Minimize_btn
            // 
            this.Minimize_btn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Minimize_btn.CheckedState.Parent = this.Minimize_btn;
            this.Minimize_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize_btn.CustomImages.Parent = this.Minimize_btn;
            this.Minimize_btn.FillColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Minimize_btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Minimize_btn.ForeColor = System.Drawing.Color.White;
            this.Minimize_btn.HoverState.Parent = this.Minimize_btn;
            this.Minimize_btn.Location = new System.Drawing.Point(224, 10);
            this.Minimize_btn.Margin = new System.Windows.Forms.Padding(4);
            this.Minimize_btn.Name = "Minimize_btn";
            this.Minimize_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minimize_btn.ShadowDecoration.Parent = this.Minimize_btn;
            this.Minimize_btn.Size = new System.Drawing.Size(19, 19);
            this.Minimize_btn.TabIndex = 2;
            this.Minimize_btn.Click += new System.EventHandler(this.Minimize_btn_Click);
            // 
            // Form_drag
            // 
            this.Form_drag.TargetControl = this.TopPanel;
            // 
            // TitleForm_lbl
            // 
            this.TitleForm_lbl.AutoSize = true;
            this.TitleForm_lbl.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleForm_lbl.Location = new System.Drawing.Point(12, 10);
            this.TitleForm_lbl.Name = "TitleForm_lbl";
            this.TitleForm_lbl.Size = new System.Drawing.Size(41, 18);
            this.TitleForm_lbl.TabIndex = 1;
            this.TitleForm_lbl.Text = "Error";
            // 
            // Button1_btn
            // 
            this.Button1_btn.CheckedState.Parent = this.Button1_btn;
            this.Button1_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1_btn.CustomImages.Parent = this.Button1_btn;
            this.Button1_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button1_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button1_btn.HoverState.Parent = this.Button1_btn;
            this.Button1_btn.Location = new System.Drawing.Point(28, 255);
            this.Button1_btn.Name = "Button1_btn";
            this.Button1_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button1_btn.ShadowDecoration.Parent = this.Button1_btn;
            this.Button1_btn.Size = new System.Drawing.Size(50, 50);
            this.Button1_btn.TabIndex = 1;
            this.Button1_btn.Text = "1";
            this.Button1_btn.Click += new System.EventHandler(this.Button1_btn_Click);
            // 
            // Button2_btn
            // 
            this.Button2_btn.CheckedState.Parent = this.Button2_btn;
            this.Button2_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button2_btn.CustomImages.Parent = this.Button2_btn;
            this.Button2_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button2_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button2_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button2_btn.HoverState.Parent = this.Button2_btn;
            this.Button2_btn.Location = new System.Drawing.Point(84, 255);
            this.Button2_btn.Name = "Button2_btn";
            this.Button2_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button2_btn.ShadowDecoration.Parent = this.Button2_btn;
            this.Button2_btn.Size = new System.Drawing.Size(50, 50);
            this.Button2_btn.TabIndex = 2;
            this.Button2_btn.Text = "2";
            this.Button2_btn.Click += new System.EventHandler(this.Button2_btn_Click);
            // 
            // Button3_btn
            // 
            this.Button3_btn.CheckedState.Parent = this.Button3_btn;
            this.Button3_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button3_btn.CustomImages.Parent = this.Button3_btn;
            this.Button3_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button3_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button3_btn.HoverState.Parent = this.Button3_btn;
            this.Button3_btn.Location = new System.Drawing.Point(140, 255);
            this.Button3_btn.Name = "Button3_btn";
            this.Button3_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button3_btn.ShadowDecoration.Parent = this.Button3_btn;
            this.Button3_btn.Size = new System.Drawing.Size(50, 50);
            this.Button3_btn.TabIndex = 3;
            this.Button3_btn.Text = "3";
            this.Button3_btn.Click += new System.EventHandler(this.Button3_btn_Click);
            // 
            // Button4_btn
            // 
            this.Button4_btn.CheckedState.Parent = this.Button4_btn;
            this.Button4_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button4_btn.CustomImages.Parent = this.Button4_btn;
            this.Button4_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button4_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button4_btn.HoverState.Parent = this.Button4_btn;
            this.Button4_btn.Location = new System.Drawing.Point(28, 199);
            this.Button4_btn.Name = "Button4_btn";
            this.Button4_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button4_btn.ShadowDecoration.Parent = this.Button4_btn;
            this.Button4_btn.Size = new System.Drawing.Size(50, 50);
            this.Button4_btn.TabIndex = 3;
            this.Button4_btn.Text = "4";
            this.Button4_btn.Click += new System.EventHandler(this.Button4_btn_Click);
            // 
            // Button5_btn
            // 
            this.Button5_btn.CheckedState.Parent = this.Button5_btn;
            this.Button5_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button5_btn.CustomImages.Parent = this.Button5_btn;
            this.Button5_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button5_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button5_btn.HoverState.Parent = this.Button5_btn;
            this.Button5_btn.Location = new System.Drawing.Point(84, 199);
            this.Button5_btn.Name = "Button5_btn";
            this.Button5_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button5_btn.ShadowDecoration.Parent = this.Button5_btn;
            this.Button5_btn.Size = new System.Drawing.Size(50, 50);
            this.Button5_btn.TabIndex = 3;
            this.Button5_btn.Text = "5";
            this.Button5_btn.Click += new System.EventHandler(this.Button5_btn_Click);
            // 
            // Button6_btn
            // 
            this.Button6_btn.CheckedState.Parent = this.Button6_btn;
            this.Button6_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button6_btn.CustomImages.Parent = this.Button6_btn;
            this.Button6_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button6_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button6_btn.HoverState.Parent = this.Button6_btn;
            this.Button6_btn.Location = new System.Drawing.Point(140, 199);
            this.Button6_btn.Name = "Button6_btn";
            this.Button6_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button6_btn.ShadowDecoration.Parent = this.Button6_btn;
            this.Button6_btn.Size = new System.Drawing.Size(50, 50);
            this.Button6_btn.TabIndex = 3;
            this.Button6_btn.Text = "6";
            this.Button6_btn.Click += new System.EventHandler(this.Button6_btn_Click);
            // 
            // Button7_btn
            // 
            this.Button7_btn.CheckedState.Parent = this.Button7_btn;
            this.Button7_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button7_btn.CustomImages.Parent = this.Button7_btn;
            this.Button7_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button7_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button7_btn.HoverState.Parent = this.Button7_btn;
            this.Button7_btn.Location = new System.Drawing.Point(28, 143);
            this.Button7_btn.Name = "Button7_btn";
            this.Button7_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button7_btn.ShadowDecoration.Parent = this.Button7_btn;
            this.Button7_btn.Size = new System.Drawing.Size(50, 50);
            this.Button7_btn.TabIndex = 3;
            this.Button7_btn.Text = "7";
            this.Button7_btn.Click += new System.EventHandler(this.Button7_btn_Click);
            // 
            // Button8_btn
            // 
            this.Button8_btn.CheckedState.Parent = this.Button8_btn;
            this.Button8_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button8_btn.CustomImages.Parent = this.Button8_btn;
            this.Button8_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button8_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button8_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button8_btn.HoverState.Parent = this.Button8_btn;
            this.Button8_btn.Location = new System.Drawing.Point(84, 143);
            this.Button8_btn.Name = "Button8_btn";
            this.Button8_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button8_btn.ShadowDecoration.Parent = this.Button8_btn;
            this.Button8_btn.Size = new System.Drawing.Size(50, 50);
            this.Button8_btn.TabIndex = 3;
            this.Button8_btn.Text = "8";
            this.Button8_btn.Click += new System.EventHandler(this.Button8_btn_Click);
            // 
            // Button9_btn
            // 
            this.Button9_btn.CheckedState.Parent = this.Button9_btn;
            this.Button9_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button9_btn.CustomImages.Parent = this.Button9_btn;
            this.Button9_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button9_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button9_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button9_btn.HoverState.Parent = this.Button9_btn;
            this.Button9_btn.Location = new System.Drawing.Point(140, 143);
            this.Button9_btn.Name = "Button9_btn";
            this.Button9_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button9_btn.ShadowDecoration.Parent = this.Button9_btn;
            this.Button9_btn.Size = new System.Drawing.Size(50, 50);
            this.Button9_btn.TabIndex = 3;
            this.Button9_btn.Text = "9";
            this.Button9_btn.Click += new System.EventHandler(this.Button9_btn_Click);
            // 
            // Button0_btn
            // 
            this.Button0_btn.CheckedState.Parent = this.Button0_btn;
            this.Button0_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button0_btn.CustomImages.Parent = this.Button0_btn;
            this.Button0_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Button0_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button0_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Button0_btn.HoverState.Parent = this.Button0_btn;
            this.Button0_btn.Location = new System.Drawing.Point(84, 311);
            this.Button0_btn.Name = "Button0_btn";
            this.Button0_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Button0_btn.ShadowDecoration.Parent = this.Button0_btn;
            this.Button0_btn.Size = new System.Drawing.Size(50, 50);
            this.Button0_btn.TabIndex = 2;
            this.Button0_btn.Text = "0";
            this.Button0_btn.Click += new System.EventHandler(this.Button0_btn_Click);
            // 
            // ButtonDot_btn
            // 
            this.ButtonDot_btn.CheckedState.Parent = this.ButtonDot_btn;
            this.ButtonDot_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonDot_btn.CustomImages.Parent = this.ButtonDot_btn;
            this.ButtonDot_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ButtonDot_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDot_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ButtonDot_btn.HoverState.Parent = this.ButtonDot_btn;
            this.ButtonDot_btn.Location = new System.Drawing.Point(140, 311);
            this.ButtonDot_btn.Name = "ButtonDot_btn";
            this.ButtonDot_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonDot_btn.ShadowDecoration.Parent = this.ButtonDot_btn;
            this.ButtonDot_btn.Size = new System.Drawing.Size(50, 50);
            this.ButtonDot_btn.TabIndex = 4;
            this.ButtonDot_btn.Text = ".";
            this.ButtonDot_btn.Click += new System.EventHandler(this.ButtonDot_btn_Click);
            // 
            // ButtonCE_btn
            // 
            this.ButtonCE_btn.CheckedState.Parent = this.ButtonCE_btn;
            this.ButtonCE_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCE_btn.CustomImages.Parent = this.ButtonCE_btn;
            this.ButtonCE_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.ButtonCE_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCE_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ButtonCE_btn.HoverState.Parent = this.ButtonCE_btn;
            this.ButtonCE_btn.Location = new System.Drawing.Point(28, 311);
            this.ButtonCE_btn.Name = "ButtonCE_btn";
            this.ButtonCE_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ButtonCE_btn.ShadowDecoration.Parent = this.ButtonCE_btn;
            this.ButtonCE_btn.Size = new System.Drawing.Size(50, 50);
            this.ButtonCE_btn.TabIndex = 4;
            this.ButtonCE_btn.Text = "CE";
            this.ButtonCE_btn.Click += new System.EventHandler(this.ButtonCE_btn_Click);
            // 
            // Plus_btn
            // 
            this.Plus_btn.CheckedState.Parent = this.Plus_btn;
            this.Plus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Plus_btn.CustomImages.Parent = this.Plus_btn;
            this.Plus_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Plus_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Plus_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Plus_btn.HoverState.Parent = this.Plus_btn;
            this.Plus_btn.Location = new System.Drawing.Point(196, 311);
            this.Plus_btn.Name = "Plus_btn";
            this.Plus_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Plus_btn.ShadowDecoration.Parent = this.Plus_btn;
            this.Plus_btn.Size = new System.Drawing.Size(50, 50);
            this.Plus_btn.TabIndex = 4;
            this.Plus_btn.Text = "+";
            this.Plus_btn.Click += new System.EventHandler(this.Plus_btn_Click);
            // 
            // Minus_btn
            // 
            this.Minus_btn.CheckedState.Parent = this.Minus_btn;
            this.Minus_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minus_btn.CustomImages.Parent = this.Minus_btn;
            this.Minus_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Minus_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minus_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Minus_btn.HoverState.Parent = this.Minus_btn;
            this.Minus_btn.Location = new System.Drawing.Point(196, 255);
            this.Minus_btn.Name = "Minus_btn";
            this.Minus_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Minus_btn.ShadowDecoration.Parent = this.Minus_btn;
            this.Minus_btn.Size = new System.Drawing.Size(50, 50);
            this.Minus_btn.TabIndex = 4;
            this.Minus_btn.Text = "-";
            this.Minus_btn.Click += new System.EventHandler(this.Minus_btn_Click);
            // 
            // Multi_btn
            // 
            this.Multi_btn.CheckedState.Parent = this.Multi_btn;
            this.Multi_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Multi_btn.CustomImages.Parent = this.Multi_btn;
            this.Multi_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Multi_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Multi_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Multi_btn.HoverState.Parent = this.Multi_btn;
            this.Multi_btn.Location = new System.Drawing.Point(196, 199);
            this.Multi_btn.Name = "Multi_btn";
            this.Multi_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Multi_btn.ShadowDecoration.Parent = this.Multi_btn;
            this.Multi_btn.Size = new System.Drawing.Size(50, 50);
            this.Multi_btn.TabIndex = 4;
            this.Multi_btn.Text = "X";
            this.Multi_btn.Click += new System.EventHandler(this.Multi_btn_Click);
            // 
            // Divide_btn
            // 
            this.Divide_btn.CheckedState.Parent = this.Divide_btn;
            this.Divide_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Divide_btn.CustomImages.Parent = this.Divide_btn;
            this.Divide_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(245)))), ((int)(((byte)(249)))));
            this.Divide_btn.Font = new System.Drawing.Font("Ubuntu", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Divide_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.Divide_btn.HoverState.Parent = this.Divide_btn;
            this.Divide_btn.Location = new System.Drawing.Point(196, 143);
            this.Divide_btn.Name = "Divide_btn";
            this.Divide_btn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Divide_btn.ShadowDecoration.Parent = this.Divide_btn;
            this.Divide_btn.Size = new System.Drawing.Size(50, 50);
            this.Divide_btn.TabIndex = 4;
            this.Divide_btn.Text = "/";
            this.Divide_btn.Click += new System.EventHandler(this.Divide_btn_Click);
            // 
            // PanelNumber
            // 
            this.PanelNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PanelNumber.DefaultText = "";
            this.PanelNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.PanelNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.PanelNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PanelNumber.DisabledState.Parent = this.PanelNumber;
            this.PanelNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.PanelNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PanelNumber.FocusedState.Parent = this.PanelNumber;
            this.PanelNumber.Font = new System.Drawing.Font("DS-Digital", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelNumber.ForeColor = System.Drawing.Color.Black;
            this.PanelNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.PanelNumber.HoverState.Parent = this.PanelNumber;
            this.PanelNumber.Location = new System.Drawing.Point(28, 69);
            this.PanelNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelNumber.Name = "PanelNumber";
            this.PanelNumber.PasswordChar = '\0';
            this.PanelNumber.PlaceholderText = "";
            this.PanelNumber.SelectedText = "";
            this.PanelNumber.ShadowDecoration.Parent = this.PanelNumber;
            this.PanelNumber.Size = new System.Drawing.Size(218, 55);
            this.PanelNumber.TabIndex = 5;
            // 
            // Index
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(277, 395);
            this.Controls.Add(this.PanelNumber);
            this.Controls.Add(this.ButtonCE_btn);
            this.Controls.Add(this.Divide_btn);
            this.Controls.Add(this.Multi_btn);
            this.Controls.Add(this.Minus_btn);
            this.Controls.Add(this.Plus_btn);
            this.Controls.Add(this.ButtonDot_btn);
            this.Controls.Add(this.Button9_btn);
            this.Controls.Add(this.Button8_btn);
            this.Controls.Add(this.Button7_btn);
            this.Controls.Add(this.Button6_btn);
            this.Controls.Add(this.Button5_btn);
            this.Controls.Add(this.Button4_btn);
            this.Controls.Add(this.Button3_btn);
            this.Controls.Add(this.Button0_btn);
            this.Controls.Add(this.Button2_btn);
            this.Controls.Add(this.Button1_btn);
            this.Controls.Add(this.TopPanel);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Index";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora";
            this.Load += new System.EventHandler(this.Index_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2CircleButton Exit_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Minimize_btn;
        private Guna.UI2.WinForms.Guna2Elipse Form_elipse;
        private Guna.UI2.WinForms.Guna2DragControl Form_drag;
        private System.Windows.Forms.Label TitleForm_lbl;
        private Guna.UI2.WinForms.Guna2CircleButton Button1_btn;
        private Guna.UI2.WinForms.Guna2TextBox PanelNumber;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonCE_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Divide_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Multi_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Minus_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Plus_btn;
        private Guna.UI2.WinForms.Guna2CircleButton ButtonDot_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button9_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button8_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button7_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button6_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button5_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button4_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button3_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button0_btn;
        private Guna.UI2.WinForms.Guna2CircleButton Button2_btn;
    }
}

