using tpmodul8_1302213089;

CovidConfig cfg = new CovidConfig();
cfg.UbahSatuan();

Console.WriteLine("Berapa suhu badan anda saat ini? Dalam nilai "+cfg.config.satuan_suhu);
string suhuBadan = Console.ReadLine();
int suhu = (int)Convert.ToInt32(suhuBadan);

Console.WriteLine("Berapa hari yang lalu (perkiraan) anda terakhir memiliki gejala demam?");
string hariInput =  Console.ReadLine();
int hari = (int)Convert.ToInt32(hariInput);

if (cfg.config.satuan_suhu == "celcius")
{
    if(suhu > 37.5)
    {
        if (hari > cfg.config.batas_hari_demam)
        {
            Console.WriteLine(cfg.config.pesan_ditolak);
        } else
        {
            Console.WriteLine(cfg.config.pesan_diterima);
        }
    } else
    {
        Console.WriteLine(cfg.config.pesan_diterima);
    }
} else if (cfg.config.satuan_suhu == "fahrenheit")
{
    if (suhu > 99.5)
    {
        if (hari > cfg.config.batas_hari_demam)
        {
            Console.WriteLine(cfg.config.pesan_ditolak);
        }
        else
        {
            Console.WriteLine(cfg.config.pesan_diterima);
        }
    }
    else
    {
        Console.WriteLine(cfg.config.pesan_diterima);
    }
}