private void btn_calcular_Click(object sender, EventArgs e)
{
    double valini = double.Parse(txt_val.Text);
    double tempo = double.Parse(txt_tmp.Text);
    string tipo = cb_op.SelectedItem.ToString();
    string tipo2 = cb_tipo.SelectedItem.ToString();
    double ir=0;
    double taxa = 0;
    double vf = valini;

    if (tipo2=="Prefixado")
    {
        taxa = double.Parse(txt_jr.Text) / 100;
    }else if (tipo2 == "IPCA")
    {
        taxa = (double.Parse(txt_ipca.Text) + 0.5) / 100;
    }else if(tipo2== "CDI")
    {
        double cdi = double.Parse(txt_cdi.Text);
        if (cdi >= 150) taxa = (13.15 * 0.50) / 100;
        else if (cdi <= 130) taxa = (13.15 * 0.30) / 100;
        else taxa = 13.15 / 100;
    }
    vf = valini * Math.Pow(1 + taxa, tempo); //Calculo para saber valor final.
    if (tipo == "CDB")
    {
        if (tempo * 365.25 <= 180) ir = vf * 0.225;
        else if (tempo * 365.25 <= 360) ir = vf * 0.20;
        else if (tempo * 365.25 <= 720) ir = vf * 0.175;
        else ir = vf * 0.15;
    } // CDB
    double res = vf - ir;
    lb_vf.Text = $"O Valor Bruto R${vf:0.00}";
    lb_im.Text = $"O Valor Liquido será:R${res:0.00}";
    lb_juros.Text = $"O Juros Será: R${taxa*100}%";
    lb_tipo.Text = $"O Investimento Tipo:{tipo} {tipo2}";
    lb_ini.Text = $"Valor Inicial R${valini:0.00}";
    if (tipo == "LCI" && tipo=="LCA")
    {
    }
    //LCI
    lb_vf.Text = $"O Valor Bruto R${vf:0.00}";
    lb_im.Text = $"O Valor Liquido será:R${res:0.00}";
    lb_juros.Text = $"O Juros Será: R${taxa * 100}%";
    lb_tipo.Text = $"O Investimento Tipo:{tipo} {tipo2}";
    lb_ini.Text = $"Valor Inicial R${valini:0.00}";
    if (tipo == "Tesouro")
    {
        if (tempo * 365.25 <= 180) ir = vf * 0.225;
        else if (tempo * 365.25 <= 360) ir = vf * 0.20;
        else if (tempo * 365.25 <= 720) ir = vf * 0.175;
        else ir = vf * 0.15;
    }
    //Tesouro
    lb_vf.Text = $"O Valor Bruto R${vf:0.00}";
    lb_im.Text = $"O Valor Liquido será:R${res:0.00}";
    lb_juros.Text = $"O Juros Será: R${taxa * 100}%";
    lb_tipo.Text = $"O Investimento Tipo:{tipo} {tipo2}";
    lb_ini.Text = $"Valor Inicial R${valini:0.00}";
    if (tipo == "Debenture")
    {
        if (tempo * 365.25 <= 180) ir = vf * 0.225;
        else if (tempo * 365.25 <= 360) ir = vf * 0.20;
        else if (tempo * 365.25 <= 720) ir = vf * 0.175;
        else ir = vf * 0.15;
    }
    //Debeture
    lb_vf.Text = $"O Valor Bruto R${vf:0.00}";
    lb_im.Text = $"O Valor Liquido será:R${res:0.00}";
    lb_juros.Text = $"O Juros Será: R${taxa * 100}%";
    lb_tipo.Text = $"O Investimento Tipo:{tipo} {tipo2}";
    lb_ini.Text = $"Valor Inicial R${valini:0.00}";
}
