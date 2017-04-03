namespace KmeansAppication
{
    partial class Mainform
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.Generate = new System.Windows.Forms.Button();
            this.Process = new System.Windows.Forms.Button();
            this.point_list = new System.Windows.Forms.ListBox();
            this.lable_2 = new System.Windows.Forms.Label();
            this.label_1 = new System.Windows.Forms.Label();
            this.set_box = new System.Windows.Forms.TextBox();
            this.cluster_box = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(319, 22);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 23);
            this.Generate.TabIndex = 0;
            this.Generate.Text = "Generate";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click_1);
            // 
            // Process
            // 
            this.Process.Location = new System.Drawing.Point(319, 60);
            this.Process.Name = "Process";
            this.Process.Size = new System.Drawing.Size(75, 23);
            this.Process.TabIndex = 1;
            this.Process.Text = "Process";
            this.Process.UseVisualStyleBackColor = true;
            this.Process.Click += new System.EventHandler(this.Process_Click);
            
            // 
            // point_list
            // 
            this.point_list.FormattingEnabled = true;
            this.point_list.ItemHeight = 12;
            this.point_list.Location = new System.Drawing.Point(416, 12);
            this.point_list.Name = "point_list";
            this.point_list.Size = new System.Drawing.Size(242, 496);
            this.point_list.TabIndex = 2;
            // 
            // lable_2
            // 
            this.lable_2.AutoSize = true;
            this.lable_2.Location = new System.Drawing.Point(23, 67);
            this.lable_2.Name = "lable_2";
            this.lable_2.Size = new System.Drawing.Size(138, 12);
            this.lable_2.TabIndex = 3;
            this.lable_2.Text = "input number of dataset";
            // 
            // label_1
            // 
            this.label_1.AutoSize = true;
            this.label_1.Location = new System.Drawing.Point(23, 25);
            this.label_1.Name = "label_1";
            this.label_1.Size = new System.Drawing.Size(142, 12);
            this.label_1.TabIndex = 4;
            this.label_1.Text = "input number of clusters";
            // 
            // set_box
            // 
            this.set_box.Location = new System.Drawing.Point(190, 62);
            this.set_box.Name = "set_box";
            this.set_box.Size = new System.Drawing.Size(100, 21);
            this.set_box.TabIndex = 5;
            this.set_box.TextChanged += new System.EventHandler(this.set_box_TextChanged);
            this.set_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Set_box_KeyPress);

            // 
            // cluster_box
            // 
            this.cluster_box.Location = new System.Drawing.Point(190, 22);
            this.cluster_box.Name = "cluster_box";
            this.cluster_box.Size = new System.Drawing.Size(100, 21);
            this.cluster_box.TabIndex = 6;
            this.cluster_box.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            this.cluster_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cluster_box_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 400);
            this.panel1.TabIndex = 7;
            // 
            // Mainform
            // 
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(668, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.cluster_box);
            this.Controls.Add(this.set_box);
            this.Controls.Add(this.label_1);
            this.Controls.Add(this.lable_2);
            this.Controls.Add(this.point_list);
            this.Controls.Add(this.Process);
            this.Controls.Add(this.Generate);
            this.Name = "Mainform";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button Process;
        private System.Windows.Forms.ListBox point_list;
        private System.Windows.Forms.Label lable_2;
        private System.Windows.Forms.Label label_1;
        private System.Windows.Forms.TextBox set_box;
        private System.Windows.Forms.TextBox cluster_box;
        private System.Windows.Forms.Panel panel1;
    }
}

