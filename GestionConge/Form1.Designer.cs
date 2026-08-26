namespace GestionConge
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblDateDebut = new Label();
            dtpDateDebut = new DateTimePicker();
            lblDateFin = new Label();
            dtpDateFin = new DateTimePicker();
            lblMotif = new Label();
            txtMotif = new TextBox();
            btnAjouter = new Button();
            btnModifier = new Button();
            btnSupprimer = new Button();
            btnAccepter = new Button();
            btnRefuser = new Button();
            dgvConges = new DataGridView();
            lblSolde = new Label();
            lblChoixEmploye = new Label();
            cmbEmploye = new ComboBox();
            lblDepartement = new Label();
            txtDepartement = new TextBox();
            lblEmail = new Label();
            txtEmail = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            txtRecherche = new TextBox();
            lblRecherche = new Label();
            grpEmploye = new GroupBox();
            grpConge = new GroupBox();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvConges).BeginInit();
            panel1.SuspendLayout();
            grpEmploye.SuspendLayout();
            grpConge.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateDebut
            // 
            lblDateDebut.AutoSize = true;
            lblDateDebut.BackColor = Color.Transparent;
            lblDateDebut.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateDebut.ForeColor = Color.FromArgb(32, 32, 32);
            lblDateDebut.Location = new Point(6, 34);
            lblDateDebut.Name = "lblDateDebut";
            lblDateDebut.Size = new Size(71, 15);
            lblDateDebut.TabIndex = 2;
            lblDateDebut.Text = "Date début :";
            lblDateDebut.Click += lblDateDebut_Click;
            // 
            // dtpDateDebut
            // 
            dtpDateDebut.Location = new Point(97, 28);
            dtpDateDebut.Name = "dtpDateDebut";
            dtpDateDebut.Size = new Size(200, 25);
            dtpDateDebut.TabIndex = 3;
            dtpDateDebut.ValueChanged += dtpDateDebut_ValueChanged;
            // 
            // lblDateFin
            // 
            lblDateFin.AutoSize = true;
            lblDateFin.BackColor = Color.Transparent;
            lblDateFin.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateFin.ForeColor = Color.FromArgb(32, 32, 32);
            lblDateFin.Location = new Point(6, 69);
            lblDateFin.Name = "lblDateFin";
            lblDateFin.Size = new Size(54, 15);
            lblDateFin.TabIndex = 4;
            lblDateFin.Text = "Date fin :";
            // 
            // dtpDateFin
            // 
            dtpDateFin.Location = new Point(97, 65);
            dtpDateFin.Name = "dtpDateFin";
            dtpDateFin.Size = new Size(200, 25);
            dtpDateFin.TabIndex = 5;
            // 
            // lblMotif
            // 
            lblMotif.AutoSize = true;
            lblMotif.Location = new Point(6, 112);
            lblMotif.Name = "lblMotif";
            lblMotif.Size = new Size(50, 17);
            lblMotif.TabIndex = 6;
            lblMotif.Text = "Motif :";
            // 
            // txtMotif
            // 
            txtMotif.BackColor = Color.White;
            txtMotif.Location = new Point(62, 112);
            txtMotif.Multiline = true;
            txtMotif.Name = "txtMotif";
            txtMotif.Size = new Size(356, 49);
            txtMotif.TabIndex = 7;
            txtMotif.TextChanged += txtMotif_TextChanged;
            // 
            // btnAjouter
            // 
            btnAjouter.BackColor = Color.FromArgb(37, 99, 235);
            btnAjouter.FlatAppearance.BorderSize = 0;
            btnAjouter.FlatStyle = FlatStyle.Flat;
            btnAjouter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAjouter.ForeColor = Color.White;
            btnAjouter.Location = new Point(32, 579);
            btnAjouter.Name = "btnAjouter";
            btnAjouter.Size = new Size(75, 23);
            btnAjouter.TabIndex = 8;
            btnAjouter.Text = "Ajouter";
            btnAjouter.UseVisualStyleBackColor = false;
            btnAjouter.Click += btnAjouter_Click;
            // 
            // btnModifier
            // 
            btnModifier.BackColor = Color.FromArgb(22, 163, 74);
            btnModifier.FlatAppearance.BorderSize = 0;
            btnModifier.FlatStyle = FlatStyle.Flat;
            btnModifier.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnModifier.ForeColor = Color.White;
            btnModifier.Location = new Point(32, 624);
            btnModifier.Name = "btnModifier";
            btnModifier.Size = new Size(75, 23);
            btnModifier.TabIndex = 9;
            btnModifier.Text = "Modifier";
            btnModifier.UseVisualStyleBackColor = false;
            btnModifier.Click += btnModifier_Click;
            // 
            // btnSupprimer
            // 
            btnSupprimer.BackColor = Color.FromArgb(225, 29, 72);
            btnSupprimer.FlatAppearance.BorderSize = 0;
            btnSupprimer.FlatStyle = FlatStyle.Flat;
            btnSupprimer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSupprimer.ForeColor = Color.White;
            btnSupprimer.Location = new Point(132, 624);
            btnSupprimer.Name = "btnSupprimer";
            btnSupprimer.Size = new Size(75, 23);
            btnSupprimer.TabIndex = 10;
            btnSupprimer.Text = "Supprimer";
            btnSupprimer.UseVisualStyleBackColor = false;
            btnSupprimer.Click += btnSupprimer_Click;
            // 
            // btnAccepter
            // 
            btnAccepter.BackColor = Color.FromArgb(22, 163, 74);
            btnAccepter.FlatAppearance.BorderSize = 0;
            btnAccepter.FlatStyle = FlatStyle.Flat;
            btnAccepter.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAccepter.ForeColor = Color.White;
            btnAccepter.Location = new Point(32, 662);
            btnAccepter.Name = "btnAccepter";
            btnAccepter.Size = new Size(75, 23);
            btnAccepter.TabIndex = 11;
            btnAccepter.Text = "Accepter";
            btnAccepter.UseVisualStyleBackColor = false;
            btnAccepter.Click += btnAccepter_Click_1;
            // 
            // btnRefuser
            // 
            btnRefuser.BackColor = Color.FromArgb(185, 28, 28);
            btnRefuser.FlatAppearance.BorderSize = 0;
            btnRefuser.FlatStyle = FlatStyle.Flat;
            btnRefuser.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRefuser.ForeColor = Color.White;
            btnRefuser.Location = new Point(132, 662);
            btnRefuser.Name = "btnRefuser";
            btnRefuser.Size = new Size(75, 23);
            btnRefuser.TabIndex = 12;
            btnRefuser.Text = "Refuser";
            btnRefuser.UseVisualStyleBackColor = false;
            btnRefuser.Click += button1_Click;
            // 
            // dgvConges
            // 
            dgvConges.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvConges.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvConges.BorderStyle = BorderStyle.None;
            dgvConges.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Teal;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConges.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConges.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(248, 250, 252);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConges.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConges.EnableHeadersVisualStyles = false;
            dgvConges.GridColor = Color.FromArgb(226, 232, 240);
            dgvConges.Location = new Point(581, 395);
            dgvConges.Name = "dgvConges";
            dgvConges.ReadOnly = true;
            dgvConges.RowTemplate.Height = 32;
            dgvConges.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvConges.Size = new Size(1219, 550);
            dgvConges.TabIndex = 13;
            dgvConges.CellClick += dgv_CellClick;
            dgvConges.CellContentClick += dataGridView1_CellContentClick;
            // 
            // lblSolde
            // 
            lblSolde.AutoSize = true;
            lblSolde.BackColor = Color.Transparent;
            lblSolde.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSolde.ForeColor = Color.FromArgb(31, 78, 120);
            lblSolde.Location = new Point(6, 203);
            lblSolde.Name = "lblSolde";
            lblSolde.Size = new Size(121, 17);
            lblSolde.TabIndex = 14;
            lblSolde.Text = "Solde Disponible :";
            lblSolde.Click += lblSolde_Click;
            // 
            // lblChoixEmploye
            // 
            lblChoixEmploye.AutoSize = true;
            lblChoixEmploye.BackColor = Color.Transparent;
            lblChoixEmploye.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChoixEmploye.ForeColor = Color.FromArgb(32, 32, 32);
            lblChoixEmploye.Location = new Point(6, 48);
            lblChoixEmploye.Name = "lblChoixEmploye";
            lblChoixEmploye.Size = new Size(59, 15);
            lblChoixEmploye.TabIndex = 15;
            lblChoixEmploye.Text = "Employé :";
            lblChoixEmploye.Click += label1_Click;
            // 
            // cmbEmploye
            // 
            cmbEmploye.BackColor = Color.White;
            cmbEmploye.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEmploye.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbEmploye.ForeColor = Color.FromArgb(32, 32, 32);
            cmbEmploye.FormattingEnabled = true;
            cmbEmploye.Location = new Point(94, 45);
            cmbEmploye.Name = "cmbEmploye";
            cmbEmploye.Size = new Size(121, 23);
            cmbEmploye.TabIndex = 16;
            cmbEmploye.SelectedIndexChanged += cmbEmploye_SelectedIndexChanged;
            // 
            // lblDepartement
            // 
            lblDepartement.AutoSize = true;
            lblDepartement.BackColor = Color.Transparent;
            lblDepartement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDepartement.ForeColor = Color.FromArgb(64, 64, 64);
            lblDepartement.Location = new Point(6, 152);
            lblDepartement.Name = "lblDepartement";
            lblDepartement.Size = new Size(82, 15);
            lblDepartement.TabIndex = 17;
            lblDepartement.Text = "Département :";
            // 
            // txtDepartement
            // 
            txtDepartement.BackColor = Color.FromArgb(243, 246, 249);
            txtDepartement.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDepartement.ForeColor = Color.FromArgb(64, 64, 64);
            txtDepartement.Location = new Point(94, 144);
            txtDepartement.Name = "txtDepartement";
            txtDepartement.ReadOnly = true;
            txtDepartement.Size = new Size(191, 23);
            txtDepartement.TabIndex = 18;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmail.Location = new Point(6, 100);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(42, 15);
            lblEmail.TabIndex = 19;
            lblEmail.Text = "Email :";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(243, 246, 249);
            txtEmail.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(64, 64, 64);
            txtEmail.Location = new Point(94, 100);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(224, 23);
            txtEmail.TabIndex = 20;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1387, 52);
            panel1.TabIndex = 21;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(877, 9);
            label1.Name = "label1";
            label1.Size = new Size(214, 25);
            label1.TabIndex = 22;
            label1.Text = "GESTION DES CONGÉS";
            // 
            // txtRecherche
            // 
            txtRecherche.Location = new Point(1680, 359);
            txtRecherche.Name = "txtRecherche";
            txtRecherche.Size = new Size(100, 23);
            txtRecherche.TabIndex = 22;
            txtRecherche.TextChanged += txtRecherche_TextChanged;
            // 
            // lblRecherche
            // 
            lblRecherche.AutoSize = true;
            lblRecherche.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecherche.Location = new Point(1596, 367);
            lblRecherche.Name = "lblRecherche";
            lblRecherche.Size = new Size(78, 15);
            lblRecherche.TabIndex = 23;
            lblRecherche.Text = "Rechercher :";
            // 
            // grpEmploye
            // 
            grpEmploye.BackColor = Color.FromArgb(224, 224, 224);
            grpEmploye.Controls.Add(lblChoixEmploye);
            grpEmploye.Controls.Add(cmbEmploye);
            grpEmploye.Controls.Add(lblEmail);
            grpEmploye.Controls.Add(txtEmail);
            grpEmploye.Controls.Add(lblSolde);
            grpEmploye.Controls.Add(txtDepartement);
            grpEmploye.Controls.Add(lblDepartement);
            grpEmploye.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpEmploye.ForeColor = Color.FromArgb(31, 78, 120);
            grpEmploye.Location = new Point(38, 101);
            grpEmploye.Name = "grpEmploye";
            grpEmploye.Size = new Size(365, 223);
            grpEmploye.TabIndex = 24;
            grpEmploye.TabStop = false;
            grpEmploye.Text = "Informations employé";
            // 
            // grpConge
            // 
            grpConge.BackColor = Color.FromArgb(224, 224, 224);
            grpConge.Controls.Add(lblMotif);
            grpConge.Controls.Add(lblDateDebut);
            grpConge.Controls.Add(dtpDateFin);
            grpConge.Controls.Add(dtpDateDebut);
            grpConge.Controls.Add(lblDateFin);
            grpConge.Controls.Add(txtMotif);
            grpConge.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpConge.ForeColor = Color.FromArgb(31, 78, 120);
            grpConge.Location = new Point(26, 367);
            grpConge.Name = "grpConge";
            grpConge.Size = new Size(494, 181);
            grpConge.TabIndex = 25;
            grpConge.TabStop = false;
            grpConge.Text = "Informations du congé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(761, 253);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(31, 78, 120);
            label3.Location = new Point(601, 338);
            label3.Name = "label3";
            label3.Size = new Size(224, 17);
            label3.TabIndex = 27;
            label3.Text = "Historique et Statut des Demandes";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1387, 933);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(grpConge);
            Controls.Add(grpEmploye);
            Controls.Add(lblRecherche);
            Controls.Add(txtRecherche);
            Controls.Add(btnAjouter);
            Controls.Add(panel1);
            Controls.Add(dgvConges);
            Controls.Add(btnModifier);
            Controls.Add(btnRefuser);
            Controls.Add(btnAccepter);
            Controls.Add(btnSupprimer);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvConges).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            grpEmploye.ResumeLayout(false);
            grpEmploye.PerformLayout();
            grpConge.ResumeLayout(false);
            grpConge.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblDateDebut;
        private DateTimePicker dtpDateDebut;
        private Label lblDateFin;
        private DateTimePicker dtpDateFin;
        private Label lblMotif;
        private TextBox txtMotif;
        private Button btnAjouter;
        private Button btnModifier;
        private Button btnSupprimer;
        private Button btnAccepter;
        private Button btnRefuser;
        private DataGridView dgvConges;
        private Label lblSolde;
        private Label lblChoixEmploye;
        private ComboBox cmbEmploye;
        private Label lblDepartement;
        private TextBox txtDepartement;
        private Label lblEmail;
        private TextBox txtEmail;
        private Panel panel1;
        private Label label1;
        private TextBox txtRecherche;
        private Label lblRecherche;
        private GroupBox grpEmploye;
        private GroupBox grpConge;
        private Label label2;
        private Label label3;
    }
}
