namespace DesafioDesktop
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lbTarefa = new System.Windows.Forms.Label();
            this.txNomeTarefa = new System.Windows.Forms.TextBox();
            this.cbPriodade = new System.Windows.Forms.ComboBox();
            this.lbPrioridade = new System.Windows.Forms.Label();
            this.dtpTarefaVencida = new System.Windows.Forms.DateTimePicker();
            this.btAdicionarTarefa = new System.Windows.Forms.Button();
            this.dtGridTarefas = new System.Windows.Forms.DataGridView();
            this.btTarefaConcluida = new System.Windows.Forms.Button();
            this.btGrafico = new System.Windows.Forms.Button();
            this.cbStatus = new System.Windows.Forms.ComboBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.chartTarefas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTarefas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTarefas)).BeginInit();
            this.SuspendLayout();
            // 
            // lbTarefa
            // 
            this.lbTarefa.AutoSize = true;
            this.lbTarefa.Location = new System.Drawing.Point(34, 36);
            this.lbTarefa.Name = "lbTarefa";
            this.lbTarefa.Size = new System.Drawing.Size(38, 13);
            this.lbTarefa.TabIndex = 0;
            this.lbTarefa.Text = "Tarefa";
            // 
            // txNomeTarefa
            // 
            this.txNomeTarefa.Location = new System.Drawing.Point(37, 52);
            this.txNomeTarefa.Name = "txNomeTarefa";
            this.txNomeTarefa.Size = new System.Drawing.Size(100, 20);
            this.txNomeTarefa.TabIndex = 1;
            // 
            // cbPriodade
            // 
            this.cbPriodade.FormattingEnabled = true;
            this.cbPriodade.Items.AddRange(new object[] {
            "Alta",
            "Média",
            "Baixa"});
            this.cbPriodade.Location = new System.Drawing.Point(143, 51);
            this.cbPriodade.Name = "cbPriodade";
            this.cbPriodade.Size = new System.Drawing.Size(121, 21);
            this.cbPriodade.TabIndex = 2;
            // 
            // lbPrioridade
            // 
            this.lbPrioridade.AutoSize = true;
            this.lbPrioridade.Location = new System.Drawing.Point(143, 36);
            this.lbPrioridade.Name = "lbPrioridade";
            this.lbPrioridade.Size = new System.Drawing.Size(103, 13);
            this.lbPrioridade.TabIndex = 3;
            this.lbPrioridade.Text = "Prioridade da Tarefa";
            // 
            // dtpTarefaVencida
            // 
            this.dtpTarefaVencida.Location = new System.Drawing.Point(449, 52);
            this.dtpTarefaVencida.Name = "dtpTarefaVencida";
            this.dtpTarefaVencida.Size = new System.Drawing.Size(200, 20);
            this.dtpTarefaVencida.TabIndex = 4;
            // 
            // btAdicionarTarefa
            // 
            this.btAdicionarTarefa.Location = new System.Drawing.Point(37, 176);
            this.btAdicionarTarefa.Name = "btAdicionarTarefa";
            this.btAdicionarTarefa.Size = new System.Drawing.Size(80, 49);
            this.btAdicionarTarefa.TabIndex = 5;
            this.btAdicionarTarefa.Text = "Adicionar Tarefa";
            this.btAdicionarTarefa.UseVisualStyleBackColor = true;
            this.btAdicionarTarefa.Click += new System.EventHandler(this.btAdicionarTarefa_Click);
            // 
            // dtGridTarefas
            // 
            this.dtGridTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTarefas.Location = new System.Drawing.Point(37, 231);
            this.dtGridTarefas.Name = "dtGridTarefas";
            this.dtGridTarefas.Size = new System.Drawing.Size(328, 207);
            this.dtGridTarefas.TabIndex = 6;
            // 
            // btTarefaConcluida
            // 
            this.btTarefaConcluida.Location = new System.Drawing.Point(197, 176);
            this.btTarefaConcluida.Name = "btTarefaConcluida";
            this.btTarefaConcluida.Size = new System.Drawing.Size(75, 49);
            this.btTarefaConcluida.TabIndex = 7;
            this.btTarefaConcluida.Text = "Concluir Tarefa";
            this.btTarefaConcluida.UseVisualStyleBackColor = true;
            this.btTarefaConcluida.Click += new System.EventHandler(this.btTarefaConcluida_Click);
            // 
            // btGrafico
            // 
            this.btGrafico.Location = new System.Drawing.Point(118, 176);
            this.btGrafico.Name = "btGrafico";
            this.btGrafico.Size = new System.Drawing.Size(75, 49);
            this.btGrafico.TabIndex = 8;
            this.btGrafico.Text = "Gerar Gráfico";
            this.btGrafico.UseVisualStyleBackColor = true;
            this.btGrafico.Click += new System.EventHandler(this.btGrafico_Click);
            // 
            // cbStatus
            // 
            this.cbStatus.FormattingEnabled = true;
            this.cbStatus.Items.AddRange(new object[] {
            "Pendente ",
            "Concluída"});
            this.cbStatus.Location = new System.Drawing.Point(270, 52);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(121, 21);
            this.cbStatus.TabIndex = 9;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(271, 36);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Status";
            // 
            // chartTarefas
            // 
            chartArea1.Name = "ChartArea1";
            this.chartTarefas.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTarefas.Legends.Add(legend1);
            this.chartTarefas.Location = new System.Drawing.Point(371, 105);
            this.chartTarefas.Name = "chartTarefas";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTarefas.Series.Add(series1);
            this.chartTarefas.Size = new System.Drawing.Size(628, 493);
            this.chartTarefas.TabIndex = 11;
            this.chartTarefas.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1443, 847);
            this.Controls.Add(this.chartTarefas);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.cbStatus);
            this.Controls.Add(this.btGrafico);
            this.Controls.Add(this.btTarefaConcluida);
            this.Controls.Add(this.dtGridTarefas);
            this.Controls.Add(this.btAdicionarTarefa);
            this.Controls.Add(this.dtpTarefaVencida);
            this.Controls.Add(this.lbPrioridade);
            this.Controls.Add(this.cbPriodade);
            this.Controls.Add(this.txNomeTarefa);
            this.Controls.Add(this.lbTarefa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTarefas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTarefas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTarefa;
        private System.Windows.Forms.TextBox txNomeTarefa;
        private System.Windows.Forms.ComboBox cbPriodade;
        private System.Windows.Forms.Label lbPrioridade;
        private System.Windows.Forms.DateTimePicker dtpTarefaVencida;
        private System.Windows.Forms.Button btAdicionarTarefa;
        private System.Windows.Forms.DataGridView dtGridTarefas;
        private System.Windows.Forms.Button btTarefaConcluida;
        private System.Windows.Forms.Button btGrafico;
        private System.Windows.Forms.ComboBox cbStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTarefas;
    }
}

