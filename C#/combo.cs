 public partial class simucenario : Form
 {
     public simucenario()
     {
         InitializeComponent();
     }
     private void label1_Click(object sender, EventArgs e)
     {

     }

     private void simucenario_Load(object sender, EventArgs e)
     {

     }

     private void btn_calcular_Click(object sender, EventArgs e)
     {
         double valini = double.Parse(txt_val.Text);
         double tempo = double.Parse(txt_tmp.Text);
         string tipo = cb_op.SelectedItem.ToString();
         string tipo2 = cb_tipo.SelectedItem.ToString();
         double ir=0;

         if (tipo2=="Prefixado")
         {
             double juros = double.Parse(txt_jr.Text);
             double divjuros = juros / 100;
             double vf = valini * Math.Pow(1 + divjuros, tempo);
             if (tipo=="CDB")
             {                 
                 if (tempo* 365.25 <= 180)
                 {
                     ir = vf * 0.225;
                 }
             }
             else if (tempo * 365.25 <= 360)
             {
                 ir = vf * 0.20;
             }
             else if (tempo * 365 <= 720)
             {
                 ir = vf * 0.175;
             }
             else
             {
                 ir = vf * 0.15;
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será{juros}%";

         }
         if (tipo2 == "Prefixado")
         {
             double juros = double.Parse(txt_jr.Text);
             double divjuros = juros / 100;
             double vf = valini * Math.Pow(1 + divjuros, tempo);
             if (tipo == "LCI")
             {
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será{juros}%";
         }
         if (tipo2 == "Prefixado")
         {
             double juros = double.Parse(txt_jr.Text);
             double divjuros = juros / 100;
             double vf = valini * Math.Pow(1 + divjuros, tempo);

             if (tipo == "LCA")
             {
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será{juros}%";
         }
         if (tipo2 == "IPCA")
         {
             double ipca = double.Parse(txt_ipca.Text);
             double somaipca = (ipca + 0.5) / 100;
             double vf = valini * Math.Pow(1 + somaipca, tempo);
             double ir2=0;

             if (tipo == "CDB")
             {
                 if (tempo *365.25 <=180)
                 {
                     ir2 = vf * 0.22; 
                 }
             }
             else if (tempo *365.25 <=360)
             {
                 ir2 = vf * 0.175;
             }
             else if (tempo *365.25 <=720)
             {
                 ir2 = vf * 0.15;
             }
             else
             {
                 ir2 = vf * 0.15;
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
         }
         if (tipo2 == "IPCA")
         {
             double ipca = double.Parse(txt_ipca.Text);
             double somaipca = (ipca / 100) + 0.05;
             double vf = valini * Math.Pow(1 + somaipca, tempo);
             double ir2 = 0;
             if (tipo == "CRI")
             {
                 if (tempo * 365.25 <= 180)
                 {
                     ir2 = vf * 0.22;
                 }
             }
             else if (tempo * 365.25 <= 360)
             {
                 ir2 = vf * 0.175;
             }
             else if (tempo * 365.25 <= 720)
             {
                 ir2 = vf * 0.15;
             }
             else
             {
                 ir2 = vf * 0.15;
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será:{jurosreal}%";
         }
         if (tipo2 == "IPCA")
         {
             double ipca = double.Parse(txt_ipca.Text);
             double somaipca = (ipca / 100) + 0.05;
             double vf = valini * Math.Pow(1 + somaipca, tempo);
             double ir2 = 0;
             if (tipo == "CRA")
             {
                 if (tempo * 365.25 <= 180)
                 {
                     ir2 = vf * 0.22;
                 }
             }
             else if (tempo * 365.25 <= 360)
             {
                 ir2 = vf * 0.175;
             }
             else if (tempo * 365.25 <= 720)
             {
                 ir2 = vf * 0.15;
             }
             else
             {
                 ir2 = vf * 0.15;
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será:{somaipca}";
         }
         if (tipo2 == "IPCA")
         {
             double ipca = double.Parse(txt_ipca.Text);
             double somaipca = (ipca / 100) + 0.05;
             double vf = valini * Math.Pow(1 + somaipca, tempo);
             double ir2 = 0;
             if (tipo == "LCI")
             {
             }
             lb_vf.Text = $"O Valor final será R$:{vf:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será:{somaipca}";
         }
         if (tipo2 == "CDI")
         {
             double cdi = double.Parse(txt_cdi.Text);
             double taxacdi = cdi;
             double cdimult = (cdi / 100);
             double vf = valini * Math.Pow(1 + cdimult, tempo);
             double ir2=0;
             if (tipo == "CDB")
             {
                 if (cdi >= 150)
                 {
                     taxacdi = 13.15 * 0.50;
                 }
                 else if (cdi <= 130)
                 {
                     taxacdi = 13.15 * 0.30;
                 }else if(cdi <= 100)
                 {
                     taxacdi = 13.15 / 100;
                 }

                 if (tempo * 365.25 <= 180)
                 {
                     ir2 = vf * 0.22;
                 }
                 double divcdi = taxacdi / 100;
             }
             else if (tempo * 365.25 <= 360)
             {
                 ir2 = vf * 0.175;
             }
             else if (tempo * 365.25 <= 720)
             {
                 ir2 = vf * 0.15;
             }
             else
             {
                 ir2 = vf * 0.15;
             }
             double res = vf - ir2;
             lb_vf.Text = $"O Valor final será R$:{res:0.00}";
             lb_tipo.Text = $"O Tipo de Investimento será:{tipo}";
             lb_ini.Text = $"O Valor Inicial é:{valini}";
             lb_juros.Text = $"O Juros total será:{cdi}";
         }

