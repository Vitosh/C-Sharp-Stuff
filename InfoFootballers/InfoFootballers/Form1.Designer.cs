namespace InfoFootballers
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.vitoshAcademyComDataSet = new InfoFootballers.VitoshAcademyComDataSet();
            this.footballersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.footballersTableAdapter = new InfoFootballers.VitoshAcademyComDataSetTableAdapters.FootballersTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clubDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_fn = new System.Windows.Forms.Label();
            this.lbl_ln = new System.Windows.Forms.Label();
            this.lbl_club = new System.Windows.Forms.Label();
            this.lbl_city = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.lbl_info = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitoshAcademyComDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.clubDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.footballersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(545, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // vitoshAcademyComDataSet
            // 
            this.vitoshAcademyComDataSet.DataSetName = "VitoshAcademyComDataSet";
            this.vitoshAcademyComDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // footballersBindingSource
            // 
            this.footballersBindingSource.DataMember = "Footballers";
            this.footballersBindingSource.DataSource = this.vitoshAcademyComDataSet;
            // 
            // footballersTableAdapter
            // 
            this.footballersTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // clubDataGridViewTextBoxColumn
            // 
            this.clubDataGridViewTextBoxColumn.DataPropertyName = "Club";
            this.clubDataGridViewTextBoxColumn.HeaderText = "Club";
            this.clubDataGridViewTextBoxColumn.Name = "clubDataGridViewTextBoxColumn";
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(50, 311);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(13, 13);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "a";
            // 
            // lbl_fn
            // 
            this.lbl_fn.AutoSize = true;
            this.lbl_fn.Location = new System.Drawing.Point(50, 339);
            this.lbl_fn.Name = "lbl_fn";
            this.lbl_fn.Size = new System.Drawing.Size(13, 13);
            this.lbl_fn.TabIndex = 2;
            this.lbl_fn.Text = "b";
            // 
            // lbl_ln
            // 
            this.lbl_ln.AutoSize = true;
            this.lbl_ln.Location = new System.Drawing.Point(50, 371);
            this.lbl_ln.Name = "lbl_ln";
            this.lbl_ln.Size = new System.Drawing.Size(13, 13);
            this.lbl_ln.TabIndex = 3;
            this.lbl_ln.Text = "c";
            // 
            // lbl_club
            // 
            this.lbl_club.AutoSize = true;
            this.lbl_club.Location = new System.Drawing.Point(50, 401);
            this.lbl_club.Name = "lbl_club";
            this.lbl_club.Size = new System.Drawing.Size(13, 13);
            this.lbl_club.TabIndex = 4;
            this.lbl_club.Text = "d";
            // 
            // lbl_city
            // 
            this.lbl_city.AutoSize = true;
            this.lbl_city.Location = new System.Drawing.Point(50, 433);
            this.lbl_city.Name = "lbl_city";
            this.lbl_city.Size = new System.Drawing.Size(13, 13);
            this.lbl_city.TabIndex = 5;
            this.lbl_city.Text = "e";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(216, 311);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(75, 23);
            this.btn_next.TabIndex = 6;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.Location = new System.Drawing.Point(216, 361);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(75, 23);
            this.btn_previous.TabIndex = 7;
            this.btn_previous.Text = "Previous";
            this.btn_previous.UseVisualStyleBackColor = true;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(329, 311);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(0, 13);
            this.lbl_info.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 502);
            this.Controls.Add(this.lbl_info);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.lbl_city);
            this.Controls.Add(this.lbl_club);
            this.Controls.Add(this.lbl_ln);
            this.Controls.Add(this.lbl_fn);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Information";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vitoshAcademyComDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.footballersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private VitoshAcademyComDataSet vitoshAcademyComDataSet;
        private System.Windows.Forms.BindingSource footballersBindingSource;
        private VitoshAcademyComDataSetTableAdapters.FootballersTableAdapter footballersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clubDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_fn;
        private System.Windows.Forms.Label lbl_ln;
        private System.Windows.Forms.Label lbl_club;
        private System.Windows.Forms.Label lbl_city;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Label lbl_info;
    }
}

