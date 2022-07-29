namespace EditorTXT
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.mArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovo = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoNovaJanela = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.mArquivoSalvarComo = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mArquivoSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarDesfazer = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarRefazer = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarRecortar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarCopiar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarColar = new System.Windows.Forms.ToolStripMenuItem();
            this.mEditarExcluir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.mEditarDataEHora = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatar = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarQuebraLinha = new System.Windows.Forms.ToolStripMenuItem();
            this.mFormatarFonte = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomAmpliar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomReduzir = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirZoomRestaurar = new System.Windows.Forms.ToolStripMenuItem();
            this.mExibirBarraStatus = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaExibirAjuda = new System.Windows.Forms.ToolStripMenuItem();
            this.mAjudaSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBar = new System.Windows.Forms.StatusStrip();
            this.statusBarLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.txtConteudo = new System.Windows.Forms.RichTextBox();
            this.menuBar.SuspendLayout();
            this.statusBar.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuBar
            // 
            this.menuBar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.menuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivo,
            this.mEditar,
            this.mFormatar,
            this.mExibir,
            this.mAjuda});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(782, 36);
            this.menuBar.TabIndex = 0;
            this.menuBar.Text = "menuStrip1";
            // 
            // mArquivo
            // 
            this.mArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mArquivoNovo,
            this.mArquivoNovaJanela,
            this.toolStripSeparator1,
            this.mArquivoAbrir,
            this.mArquivoSalvar,
            this.mArquivoSalvarComo,
            this.toolStripSeparator2,
            this.mArquivoSair});
            this.mArquivo.Name = "mArquivo";
            this.mArquivo.Size = new System.Drawing.Size(97, 32);
            this.mArquivo.Text = "Arquivo";
            // 
            // mArquivoNovo
            // 
            this.mArquivoNovo.Image = global::EditorTXT.Properties.Resources.new_document;
            this.mArquivoNovo.Name = "mArquivoNovo";
            this.mArquivoNovo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.mArquivoNovo.Size = new System.Drawing.Size(335, 32);
            this.mArquivoNovo.Text = "Novo";
            this.mArquivoNovo.Click += new System.EventHandler(this.mArquivoNovo_Click);
            // 
            // mArquivoNovaJanela
            // 
            this.mArquivoNovaJanela.Image = global::EditorTXT.Properties.Resources.notes;
            this.mArquivoNovaJanela.Name = "mArquivoNovaJanela";
            this.mArquivoNovaJanela.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.mArquivoNovaJanela.Size = new System.Drawing.Size(335, 32);
            this.mArquivoNovaJanela.Text = "Nova Janela";
            this.mArquivoNovaJanela.Click += new System.EventHandler(this.mArquivoNovaJanela_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(332, 6);
            // 
            // mArquivoAbrir
            // 
            this.mArquivoAbrir.Image = global::EditorTXT.Properties.Resources.folder;
            this.mArquivoAbrir.Name = "mArquivoAbrir";
            this.mArquivoAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.mArquivoAbrir.Size = new System.Drawing.Size(335, 32);
            this.mArquivoAbrir.Text = "Abrir";
            this.mArquivoAbrir.Click += new System.EventHandler(this.mArquivoAbrir_Click);
            // 
            // mArquivoSalvar
            // 
            this.mArquivoSalvar.Image = global::EditorTXT.Properties.Resources.save;
            this.mArquivoSalvar.Name = "mArquivoSalvar";
            this.mArquivoSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvar.Size = new System.Drawing.Size(335, 32);
            this.mArquivoSalvar.Text = "Salvar";
            this.mArquivoSalvar.Click += new System.EventHandler(this.mArquivoSalvar_Click);
            // 
            // mArquivoSalvarComo
            // 
            this.mArquivoSalvarComo.Image = global::EditorTXT.Properties.Resources.save;
            this.mArquivoSalvarComo.Name = "mArquivoSalvarComo";
            this.mArquivoSalvarComo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.mArquivoSalvarComo.Size = new System.Drawing.Size(335, 32);
            this.mArquivoSalvarComo.Text = "Salvar Como";
            this.mArquivoSalvarComo.Click += new System.EventHandler(this.mArquivoSalvarComo_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(332, 6);
            // 
            // mArquivoSair
            // 
            this.mArquivoSair.Image = global::EditorTXT.Properties.Resources.exit;
            this.mArquivoSair.Name = "mArquivoSair";
            this.mArquivoSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mArquivoSair.Size = new System.Drawing.Size(335, 32);
            this.mArquivoSair.Text = "Sair";
            this.mArquivoSair.Click += new System.EventHandler(this.mArquivoSair_Click);
            // 
            // mEditar
            // 
            this.mEditar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mEditarDesfazer,
            this.mEditarRefazer,
            this.toolStripSeparator3,
            this.mEditarRecortar,
            this.mEditarCopiar,
            this.mEditarColar,
            this.mEditarExcluir,
            this.toolStripSeparator4,
            this.mEditarDataEHora});
            this.mEditar.Name = "mEditar";
            this.mEditar.Size = new System.Drawing.Size(77, 32);
            this.mEditar.Text = "Editar";
            // 
            // mEditarDesfazer
            // 
            this.mEditarDesfazer.Name = "mEditarDesfazer";
            this.mEditarDesfazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.mEditarDesfazer.Size = new System.Drawing.Size(245, 32);
            this.mEditarDesfazer.Text = "Desfazer";
            this.mEditarDesfazer.Click += new System.EventHandler(this.mEditarDesfazer_Click);
            // 
            // mEditarRefazer
            // 
            this.mEditarRefazer.Name = "mEditarRefazer";
            this.mEditarRefazer.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.mEditarRefazer.Size = new System.Drawing.Size(245, 32);
            this.mEditarRefazer.Text = "Refazer";
            this.mEditarRefazer.Click += new System.EventHandler(this.mEditarRefazer_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(242, 6);
            // 
            // mEditarRecortar
            // 
            this.mEditarRecortar.Name = "mEditarRecortar";
            this.mEditarRecortar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.mEditarRecortar.Size = new System.Drawing.Size(245, 32);
            this.mEditarRecortar.Text = "Recortar";
            this.mEditarRecortar.Click += new System.EventHandler(this.mEditarRecortar_Click);
            // 
            // mEditarCopiar
            // 
            this.mEditarCopiar.Name = "mEditarCopiar";
            this.mEditarCopiar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.mEditarCopiar.Size = new System.Drawing.Size(245, 32);
            this.mEditarCopiar.Text = "Copiar";
            this.mEditarCopiar.Click += new System.EventHandler(this.mEditarCopiar_Click);
            // 
            // mEditarColar
            // 
            this.mEditarColar.Image = global::EditorTXT.Properties.Resources.text;
            this.mEditarColar.Name = "mEditarColar";
            this.mEditarColar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.mEditarColar.Size = new System.Drawing.Size(245, 32);
            this.mEditarColar.Text = "Colar";
            this.mEditarColar.Click += new System.EventHandler(this.mEditarColar_Click);
            // 
            // mEditarExcluir
            // 
            this.mEditarExcluir.Name = "mEditarExcluir";
            this.mEditarExcluir.ShortcutKeyDisplayString = "Delete";
            this.mEditarExcluir.Size = new System.Drawing.Size(245, 32);
            this.mEditarExcluir.Text = "Excluir";
            this.mEditarExcluir.Click += new System.EventHandler(this.mEditarExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(242, 6);
            // 
            // mEditarDataEHora
            // 
            this.mEditarDataEHora.Name = "mEditarDataEHora";
            this.mEditarDataEHora.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.mEditarDataEHora.Size = new System.Drawing.Size(245, 32);
            this.mEditarDataEHora.Text = "Data e Hora";
            this.mEditarDataEHora.Click += new System.EventHandler(this.mEditarDataEHora_Click);
            // 
            // mFormatar
            // 
            this.mFormatar.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFormatarQuebraLinha,
            this.mFormatarFonte});
            this.mFormatar.Name = "mFormatar";
            this.mFormatar.Size = new System.Drawing.Size(107, 32);
            this.mFormatar.Text = "Formatar";
            // 
            // mFormatarQuebraLinha
            // 
            this.mFormatarQuebraLinha.CheckOnClick = true;
            this.mFormatarQuebraLinha.Name = "mFormatarQuebraLinha";
            this.mFormatarQuebraLinha.Size = new System.Drawing.Size(358, 32);
            this.mFormatarQuebraLinha.Text = "Quebra Automática de Linha";
            this.mFormatarQuebraLinha.Click += new System.EventHandler(this.mFormatarQuebraLinha_Click);
            // 
            // mFormatarFonte
            // 
            this.mFormatarFonte.Name = "mFormatarFonte";
            this.mFormatarFonte.Size = new System.Drawing.Size(358, 32);
            this.mFormatarFonte.Text = "Fonte";
            this.mFormatarFonte.Click += new System.EventHandler(this.mFormatarFonte_Click);
            // 
            // mExibir
            // 
            this.mExibir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoom,
            this.mExibirBarraStatus});
            this.mExibir.Name = "mExibir";
            this.mExibir.Size = new System.Drawing.Size(75, 32);
            this.mExibir.Text = "Exibir";
            // 
            // mExibirZoom
            // 
            this.mExibirZoom.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mExibirZoomAmpliar,
            this.mExibirZoomReduzir,
            this.mExibirZoomRestaurar});
            this.mExibirZoom.Image = global::EditorTXT.Properties.Resources.zoom1;
            this.mExibirZoom.Name = "mExibirZoom";
            this.mExibirZoom.Size = new System.Drawing.Size(234, 32);
            this.mExibirZoom.Text = "Zoom";
            // 
            // mExibirZoomAmpliar
            // 
            this.mExibirZoomAmpliar.Image = global::EditorTXT.Properties.Resources.zoom;
            this.mExibirZoomAmpliar.Name = "mExibirZoomAmpliar";
            this.mExibirZoomAmpliar.ShortcutKeyDisplayString = "Ctrl+adição";
            this.mExibirZoomAmpliar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Oemplus)));
            this.mExibirZoomAmpliar.Size = new System.Drawing.Size(303, 32);
            this.mExibirZoomAmpliar.Text = "Ampliar";
            this.mExibirZoomAmpliar.Click += new System.EventHandler(this.mExibirZoomAmpliar_Click);
            // 
            // mExibirZoomReduzir
            // 
            this.mExibirZoomReduzir.Image = global::EditorTXT.Properties.Resources.zoom;
            this.mExibirZoomReduzir.Name = "mExibirZoomReduzir";
            this.mExibirZoomReduzir.ShortcutKeyDisplayString = "Ctrl+sibtração";
            this.mExibirZoomReduzir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.OemMinus)));
            this.mExibirZoomReduzir.Size = new System.Drawing.Size(303, 32);
            this.mExibirZoomReduzir.Text = "Reduzir";
            this.mExibirZoomReduzir.Click += new System.EventHandler(this.mExibirZoomReduzir_Click);
            // 
            // mExibirZoomRestaurar
            // 
            this.mExibirZoomRestaurar.Name = "mExibirZoomRestaurar";
            this.mExibirZoomRestaurar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.mExibirZoomRestaurar.Size = new System.Drawing.Size(303, 32);
            this.mExibirZoomRestaurar.Text = "Restaurar";
            this.mExibirZoomRestaurar.Click += new System.EventHandler(this.mExibirZoomRestaurar_Click);
            // 
            // mExibirBarraStatus
            // 
            this.mExibirBarraStatus.Checked = true;
            this.mExibirBarraStatus.CheckOnClick = true;
            this.mExibirBarraStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mExibirBarraStatus.Name = "mExibirBarraStatus";
            this.mExibirBarraStatus.Size = new System.Drawing.Size(234, 32);
            this.mExibirBarraStatus.Text = "Barra de Status";
            this.mExibirBarraStatus.Click += new System.EventHandler(this.mExibirBarraStatus_Click);
            // 
            // mAjuda
            // 
            this.mAjuda.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAjudaExibirAjuda,
            this.mAjudaSobre});
            this.mAjuda.Name = "mAjuda";
            this.mAjuda.Size = new System.Drawing.Size(78, 32);
            this.mAjuda.Text = "Ajuda";
            // 
            // mAjudaExibirAjuda
            // 
            this.mAjudaExibirAjuda.Image = global::EditorTXT.Properties.Resources.help;
            this.mAjudaExibirAjuda.Name = "mAjudaExibirAjuda";
            this.mAjudaExibirAjuda.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mAjudaExibirAjuda.Size = new System.Drawing.Size(235, 32);
            this.mAjudaExibirAjuda.Text = "Exibir Ajuda";
            this.mAjudaExibirAjuda.Click += new System.EventHandler(this.mAjudaExibirAjuda_Click);
            // 
            // mAjudaSobre
            // 
            this.mAjudaSobre.Name = "mAjudaSobre";
            this.mAjudaSobre.Size = new System.Drawing.Size(235, 32);
            this.mAjudaSobre.Text = "Sobre o Editor";
            this.mAjudaSobre.Click += new System.EventHandler(this.mAjudaSobre_Click);
            // 
            // statusBar
            // 
            this.statusBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBarLabel});
            this.statusBar.Location = new System.Drawing.Point(0, 527);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(782, 26);
            this.statusBar.TabIndex = 1;
            this.statusBar.Text = "statusStrip1";
            // 
            // statusBarLabel
            // 
            this.statusBarLabel.Name = "statusBarLabel";
            this.statusBarLabel.Size = new System.Drawing.Size(49, 20);
            this.statusBarLabel.Text = "100 %";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripSeparator5,
            this.toolStripButton5,
            this.toolStripSeparator6,
            this.toolStripButton6,
            this.toolStripButton8,
            this.toolStripButton7,
            this.toolStripSeparator7,
            this.toolStripButton9});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 35);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::EditorTXT.Properties.Resources.new_document;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::EditorTXT.Properties.Resources.folder;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton2.Text = "toolStripButton2";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = global::EditorTXT.Properties.Resources.save;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton3.Text = "toolStripButton3";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Font = new System.Drawing.Font("Sylfaen", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton5.Text = "A";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toolStripButton6.ForeColor = System.Drawing.Color.Red;
            this.toolStripButton6.Image = global::EditorTXT.Properties.Resources.zoom;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(44, 32);
            this.toolStripButton6.Text = "-";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = global::EditorTXT.Properties.Resources.zoom;
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton8.Text = "toolStripButton8";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.ForeColor = System.Drawing.Color.Green;
            this.toolStripButton7.Image = global::EditorTXT.Properties.Resources.zoom;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(43, 32);
            this.toolStripButton7.Text = "+";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 35);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = global::EditorTXT.Properties.Resources.help;
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(29, 32);
            this.toolStripButton9.Text = "toolStripButton9";
            // 
            // txtConteudo
            // 
            this.txtConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtConteudo.Location = new System.Drawing.Point(0, 71);
            this.txtConteudo.Name = "txtConteudo";
            this.txtConteudo.Size = new System.Drawing.Size(782, 456);
            this.txtConteudo.TabIndex = 4;
            this.txtConteudo.Text = "";
            this.txtConteudo.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.txtConteudo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusBar);
            this.Controls.Add(this.menuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditorTXT";
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.statusBar.ResumeLayout(false);
            this.statusBar.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem mArquivo;
        private System.Windows.Forms.ToolStripMenuItem mEditar;
        private System.Windows.Forms.ToolStripMenuItem mFormatar;
        private System.Windows.Forms.ToolStripMenuItem mExibir;
        private System.Windows.Forms.ToolStripMenuItem mAjuda;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovo;
        private System.Windows.Forms.ToolStripMenuItem mArquivoNovaJanela;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mArquivoAbrir;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvar;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSalvarComo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mArquivoSair;
        private System.Windows.Forms.ToolStripMenuItem mEditarDesfazer;
        private System.Windows.Forms.ToolStripMenuItem mEditarRefazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mEditarRecortar;
        private System.Windows.Forms.ToolStripMenuItem mEditarCopiar;
        private System.Windows.Forms.ToolStripMenuItem mEditarColar;
        private System.Windows.Forms.ToolStripMenuItem mEditarExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem mEditarDataEHora;
        private System.Windows.Forms.ToolStripMenuItem mFormatarQuebraLinha;
        private System.Windows.Forms.ToolStripMenuItem mFormatarFonte;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoom;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomAmpliar;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomReduzir;
        private System.Windows.Forms.ToolStripMenuItem mExibirZoomRestaurar;
        private System.Windows.Forms.ToolStripMenuItem mExibirBarraStatus;
        private System.Windows.Forms.ToolStripMenuItem mAjudaExibirAjuda;
        private System.Windows.Forms.ToolStripMenuItem mAjudaSobre;
        private System.Windows.Forms.StatusStrip statusBar;
        private System.Windows.Forms.ToolStripStatusLabel statusBarLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.RichTextBox txtConteudo;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.ToolStripButton toolStripButton8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton toolStripButton9;
    }
}
