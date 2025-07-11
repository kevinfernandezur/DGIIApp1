﻿using DGIIApp.Models;

namespace DGIIApp.Data
{
    public static class DbInitializer
    {
        public static void Seed(AppDbContext context)
        {
            if (!context.Contribuyentes.Any())
            {
                var contribuyentes = new List<Contribuyente>
                {
                    new Contribuyente { RncCedula = "10000000001", Nombre = "DORITA FIGUEROA ZURITA", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000002", Nombre = "DOROTEA GUARDIOLA SANMIGUEL", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000003", Nombre = "JULIE CABEZAS PEDRAZA", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000004", Nombre = "CONSTRUCTORA HIGÜEY", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000005", Nombre = "ALEX FARRÉ EGEA", Tipo = "PERSONA FISICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000006", Nombre = "MANUELA MALENA GASCÓN TOMÉ", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000007", Nombre = "SUSANITA CASADO DURÁN", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000008", Nombre = "LA SIRENA", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000009", Nombre = "GRUPO SID", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000010", Nombre = "FLAVIA ZARAGOZA BARRIGA", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000011", Nombre = "DISTRIBUIDORA CIBAO", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000012", Nombre = "BANRESERVAS", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000013", Nombre = "BALDUINO REVILLA MATEO", Tipo = "PERSONA FISICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000014", Nombre = "ALTICE", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000015", Nombre = "CLARO", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000016", Nombre = "FERRETERÍA DOMINICANA", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000017", Nombre = "CIRO COSTA HEREDIA", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000018", Nombre = "DISTRIBUIDORA CIBAO", Tipo = "PERSONA JURIDICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000019", Nombre = "DUILIO DE ROLDAN", Tipo = "PERSONA FISICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000020", Nombre = "BANRESERVAS", Tipo = "PERSONA JURIDICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000021", Nombre = "ABRAHAM TORRES ANTÚNEZ", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000022", Nombre = "ANASTASIA DEL NOGUÉS", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000023", Nombre = "GRUPO RICA", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000024", Nombre = "ROSA MARÍA ARMENGOL GABALDÓN", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000025", Nombre = "RITA NARCISA RIOS RODRIGO", Tipo = "PERSONA FISICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000026", Nombre = "JENNIFER TERUEL PASCUAL", Tipo = "PERSONA FISICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000027", Nombre = "FERRETERÍA DOMINICANA", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000028", Nombre = "PILAR PERERA NAVARRO", Tipo = "PERSONA FISICA", Estatus = "INACTIVO" },
                    new Contribuyente { RncCedula = "10000000029", Nombre = "BANRESERVAS", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" },
                    new Contribuyente { RncCedula = "10000000030", Nombre = "CLARO", Tipo = "PERSONA JURIDICA", Estatus = "ACTIVO" }
                };

                context.Contribuyentes.AddRange(contribuyentes);
                context.SaveChanges();
            }

            if (!context.Comprobantes.Any())
            {
                var comprobantes = new List<ComprobanteFiscal>
                {
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001000", Monto = 2795.88m, Itbis18 = 503.26m },
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001001", Monto = 5587.28m, Itbis18 = 1005.71m },
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001002", Monto = 6527.91m, Itbis18 = 1175.02m },
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001003", Monto = 4691.06m, Itbis18 = 844.39m },
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001004", Monto = 3254.32m, Itbis18 = 585.78m },
                    new ComprobanteFiscal { RncCedula = "10000000001", NCF = "E310000001005", Monto = 9060.47m, Itbis18 = 1630.88m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002000", Monto = 5629.11m, Itbis18 = 1013.24m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002001", Monto = 4774.42m, Itbis18 = 859.4m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002002", Monto = 5527.06m, Itbis18 = 994.87m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002003", Monto = 1635.81m, Itbis18 = 294.45m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002004", Monto = 361.42m, Itbis18 = 65.06m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002005", Monto = 156.36m, Itbis18 = 28.14m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002006", Monto = 1720.92m, Itbis18 = 309.77m },
                    new ComprobanteFiscal { RncCedula = "10000000002", NCF = "E310000002007", Monto = 185.38m, Itbis18 = 33.37m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003000", Monto = 718.09m, Itbis18 = 129.26m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003001", Monto = 6993.7m, Itbis18 = 1258.87m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003002", Monto = 6997.57m, Itbis18 = 1259.56m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003003", Monto = 7815.74m, Itbis18 = 1406.83m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003004", Monto = 3512.35m, Itbis18 = 632.22m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003005", Monto = 3063.23m, Itbis18 = 551.38m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003006", Monto = 4404.37m, Itbis18 = 792.79m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003007", Monto = 8161.39m, Itbis18 = 1469.05m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003008", Monto = 6972.61m, Itbis18 = 1255.07m },
                    new ComprobanteFiscal { RncCedula = "10000000003", NCF = "E310000003009", Monto = 3682.44m, Itbis18 = 662.84m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004000", Monto = 9081.32m, Itbis18 = 1634.64m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004001", Monto = 7414.81m, Itbis18 = 1334.67m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004002", Monto = 9488.5m, Itbis18 = 1707.93m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004003", Monto = 8696.99m, Itbis18 = 1565.46m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004004", Monto = 468.34m, Itbis18 = 84.3m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004005", Monto = 1982.05m, Itbis18 = 356.77m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004006", Monto = 7013.27m, Itbis18 = 1262.39m },
                    new ComprobanteFiscal { RncCedula = "10000000004", NCF = "E310000004007", Monto = 5254.16m, Itbis18 = 945.75m },
                    new ComprobanteFiscal { RncCedula = "10000000006", NCF = "E310000006000", Monto = 9734.32m, Itbis18 = 1752.18m },
                    new ComprobanteFiscal { RncCedula = "10000000006", NCF = "E310000006001", Monto = 8876.88m, Itbis18 = 1597.84m },
                    new ComprobanteFiscal { RncCedula = "10000000006", NCF = "E310000006002", Monto = 9511.03m, Itbis18 = 1711.99m },
                    new ComprobanteFiscal { RncCedula = "10000000006", NCF = "E310000006003", Monto = 4708.13m, Itbis18 = 847.46m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007000", Monto = 9473.23m, Itbis18 = 1705.18m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007001", Monto = 1335.77m, Itbis18 = 240.44m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007002", Monto = 2149.97m, Itbis18 = 386.99m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007003", Monto = 1056.84m, Itbis18 = 190.23m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007004", Monto = 6508.75m, Itbis18 = 1171.58m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007005", Monto = 4370.19m, Itbis18 = 786.63m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007006", Monto = 7052.24m, Itbis18 = 1269.4m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007007", Monto = 4809.85m, Itbis18 = 865.77m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007008", Monto = 9968.32m, Itbis18 = 1794.3m },
                    new ComprobanteFiscal { RncCedula = "10000000007", NCF = "E310000007009", Monto = 4385.53m, Itbis18 = 789.4m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008000", Monto = 7282.8m, Itbis18 = 1310.9m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008001", Monto = 7638.31m, Itbis18 = 1374.9m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008002", Monto = 565.63m, Itbis18 = 101.81m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008003", Monto = 5120.66m, Itbis18 = 921.72m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008004", Monto = 6616.43m, Itbis18 = 1190.96m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008005", Monto = 284.1m, Itbis18 = 51.14m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008006", Monto = 4138.53m, Itbis18 = 744.94m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008007", Monto = 2552.01m, Itbis18 = 459.36m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008008", Monto = 2003.8m, Itbis18 = 360.68m },
                    new ComprobanteFiscal { RncCedula = "10000000008", NCF = "E310000008009", Monto = 5906.91m, Itbis18 = 1063.24m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009000", Monto = 2387.67m, Itbis18 = 429.78m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009001", Monto = 3302.07m, Itbis18 = 594.37m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009002", Monto = 4731.88m, Itbis18 = 851.74m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009003", Monto = 7554.22m, Itbis18 = 1359.76m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009004", Monto = 9050.99m, Itbis18 = 1629.18m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009005", Monto = 2896.75m, Itbis18 = 521.41m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009006", Monto = 715.16m, Itbis18 = 128.73m },
                    new ComprobanteFiscal { RncCedula = "10000000009", NCF = "E310000009007", Monto = 9717.63m, Itbis18 = 1749.17m },
                    new ComprobanteFiscal { RncCedula = "10000000010", NCF = "E310000010000", Monto = 3333.62m, Itbis18 = 600.05m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012000", Monto = 4832.46m, Itbis18 = 869.84m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012001", Monto = 912.89m, Itbis18 = 164.32m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012002", Monto = 5182.46m, Itbis18 = 932.84m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012003", Monto = 2979.25m, Itbis18 = 536.26m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012004", Monto = 8252.37m, Itbis18 = 1485.43m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012005", Monto = 5281.64m, Itbis18 = 950.7m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012006", Monto = 8462.04m, Itbis18 = 1523.17m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012007", Monto = 6856.03m, Itbis18 = 1234.09m },
                    new ComprobanteFiscal { RncCedula = "10000000012", NCF = "E310000012008", Monto = 1846.06m, Itbis18 = 332.29m },
      
                    new ComprobanteFiscal { RncCedula = "10000000014", NCF = "E310000014000", Monto = 3387.45m, Itbis18 = 609.74m },
                    new ComprobanteFiscal { RncCedula = "10000000014", NCF = "E310000014001", Monto = 1224.74m, Itbis18 = 220.45m },
                    new ComprobanteFiscal { RncCedula = "10000000014", NCF = "E310000014002", Monto = 2326.97m, Itbis18 = 418.85m },
                    new ComprobanteFiscal { RncCedula = "10000000015", NCF = "E310000015000", Monto = 5296.87m, Itbis18 = 953.44m },
                    new ComprobanteFiscal { RncCedula = "10000000015", NCF = "E310000015001", Monto = 8784.82m, Itbis18 = 1581.27m },
                    new ComprobanteFiscal { RncCedula = "10000000015", NCF = "E310000015002", Monto = 1518.58m, Itbis18 = 273.34m },
                    new ComprobanteFiscal { RncCedula = "10000000015", NCF = "E310000015003", Monto = 6072.95m, Itbis18 = 1093.13m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016000", Monto = 5602.4m, Itbis18 = 1008.43m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016001", Monto = 6723.65m, Itbis18 = 1210.26m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016002", Monto = 9677.22m, Itbis18 = 1741.9m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016003", Monto = 2430.07m, Itbis18 = 437.41m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016004", Monto = 7645.87m, Itbis18 = 1376.26m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016005", Monto = 8708.96m, Itbis18 = 1567.61m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016006", Monto = 1582.78m, Itbis18 = 284.9m },
                    new ComprobanteFiscal { RncCedula = "10000000016", NCF = "E310000016007", Monto = 4408.17m, Itbis18 = 793.47m },
                    new ComprobanteFiscal { RncCedula = "10000000017", NCF = "E310000017000", Monto = 8811.27m, Itbis18 = 1586.03m },
                 
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021000", Monto = 9992.71m, Itbis18 = 1798.69m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021001", Monto = 4886.33m, Itbis18 = 879.54m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021002", Monto = 1323.56m, Itbis18 = 238.24m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021003", Monto = 5718.44m, Itbis18 = 1029.32m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021004", Monto = 7322.57m, Itbis18 = 1318.06m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021005", Monto = 588.31m, Itbis18 = 105.9m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021006", Monto = 4662.84m, Itbis18 = 839.31m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021007", Monto = 7394.62m, Itbis18 = 1331.03m },
                    new ComprobanteFiscal { RncCedula = "10000000021", NCF = "E310000021008", Monto = 8035.15m, Itbis18 = 1446.33m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022000", Monto = 3147.95m, Itbis18 = 566.63m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022001", Monto = 4068.32m, Itbis18 = 732.3m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022002", Monto = 2275.22m, Itbis18 = 409.54m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022003", Monto = 2854.27m, Itbis18 = 513.77m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022004", Monto = 7046.51m, Itbis18 = 1268.37m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022005", Monto = 1215.54m, Itbis18 = 218.8m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022006", Monto = 1289.06m, Itbis18 = 232.03m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022007", Monto = 9407.66m, Itbis18 = 1693.38m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022008", Monto = 2485.76m, Itbis18 = 447.44m },
                    new ComprobanteFiscal { RncCedula = "10000000022", NCF = "E310000022009", Monto = 1693.7m, Itbis18 = 304.87m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023000", Monto = 8427.32m, Itbis18 = 1516.92m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023001", Monto = 316.15m, Itbis18 = 56.91m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023002", Monto = 876.07m, Itbis18 = 157.69m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023003", Monto = 8833.42m, Itbis18 = 1590.02m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023004", Monto = 5329.72m, Itbis18 = 959.35m },
                    new ComprobanteFiscal { RncCedula = "10000000023", NCF = "E310000023005", Monto = 3492.32m, Itbis18 = 628.62m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024000", Monto = 7212.47m, Itbis18 = 1298.24m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024001", Monto = 2379.58m, Itbis18 = 428.32m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024002", Monto = 7022.36m, Itbis18 = 1264.02m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024003", Monto = 8385.82m, Itbis18 = 1509.45m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024004", Monto = 3008.88m, Itbis18 = 541.6m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024005", Monto = 7375.33m, Itbis18 = 1327.56m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024006", Monto = 9931.46m, Itbis18 = 1787.66m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024007", Monto = 4961.78m, Itbis18 = 893.12m },
                    new ComprobanteFiscal { RncCedula = "10000000024", NCF = "E310000024008", Monto = 4439.71m, Itbis18 = 799.15m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025000", Monto = 4438.74m, Itbis18 = 798.97m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025001", Monto = 5268.65m, Itbis18 = 948.36m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025002", Monto = 5651.27m, Itbis18 = 1017.23m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025003", Monto = 3862.09m, Itbis18 = 695.18m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025004", Monto = 2867.28m, Itbis18 = 516.11m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025005", Monto = 7879.08m, Itbis18 = 1418.23m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025006", Monto = 7047.36m, Itbis18 = 1268.52m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025007", Monto = 530.35m, Itbis18 = 95.46m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025008", Monto = 7704.59m, Itbis18 = 1386.83m },
                    new ComprobanteFiscal { RncCedula = "10000000025", NCF = "E310000025009", Monto = 1913.29m, Itbis18 = 344.39m },
                    new ComprobanteFiscal { RncCedula = "10000000027", NCF = "E310000027000", Monto = 6802.12m, Itbis18 = 1224.38m },
                    new ComprobanteFiscal { RncCedula = "10000000027", NCF = "E310000027001", Monto = 1868.47m, Itbis18 = 336.32m },
                    new ComprobanteFiscal { RncCedula = "10000000027", NCF = "E310000027002", Monto = 8577.59m, Itbis18 = 1543.97m },
       
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029000", Monto = 6859.38m, Itbis18 = 1234.69m },
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029001", Monto = 9577.45m, Itbis18 = 1723.94m },
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029002", Monto = 3955.06m, Itbis18 = 711.91m },
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029003", Monto = 3095.17m, Itbis18 = 557.13m },
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029004", Monto = 1587.79m, Itbis18 = 285.8m },
                    new ComprobanteFiscal { RncCedula = "10000000029", NCF = "E310000029005", Monto = 4044.86m, Itbis18 = 728.07m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030000", Monto = 4059.54m, Itbis18 = 730.72m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030001", Monto = 7939.33m, Itbis18 = 1429.08m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030002", Monto = 9551.62m, Itbis18 = 1719.29m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030003", Monto = 7451.66m, Itbis18 = 1341.3m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030004", Monto = 7290.54m, Itbis18 = 1312.3m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030005", Monto = 622.17m, Itbis18 = 111.99m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030006", Monto = 8833.81m, Itbis18 = 1590.09m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030007", Monto = 4019.51m, Itbis18 = 723.51m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030008", Monto = 6394.86m, Itbis18 = 1151.07m },
                    new ComprobanteFiscal { RncCedula = "10000000030", NCF = "E310000030009", Monto = 7098.12m, Itbis18 = 1277.66m }
                };

                context.Comprobantes.AddRange(comprobantes);
                context.SaveChanges();
            }

            var registros = context.Comprobantes.ToList();
            foreach (var c in registros)
            {
                Console.WriteLine($"NCF: {c.NCF}, Monto: {c.Monto}, ITBIS: {c.Itbis18}");
            }

        }


    }
}
