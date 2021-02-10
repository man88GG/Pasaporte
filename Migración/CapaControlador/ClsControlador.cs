﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModelo;

namespace CapaControlador
{
   public class ClsControlador
    {

        ClsSentencias Sn = new ClsSentencias();
        //funcion que obtiene el codigo de la boleta que se esta solicitando
        public int funcObtenerCodigoBoleta(int numeroRecibo,int numeroBoleta)
        {
            int CodigoBoleta = Sn.funcConsultarBoleta(numeroRecibo,numeroBoleta);
            return CodigoBoleta;
        }
        //funcion que retorna los todos los datos de una tabla de un campo en especifico
        public string[] funcItems(string Tabla, string Campo1)
        {
            string[] Items = Sn.funcLlenarCmb(Tabla, Campo1);
            return Items;
        }
        //funcion que permite obtener un campo en especificode una tabla por medio de su ID
        public string funcObtenerDato(int Codigo,string Campo,string Tabla,string nombreId)
        {
            string  Dato = Sn.funcDatos(Codigo,Campo,Tabla,nombreId);
            return Dato;
        }
        public string[] funcItemsComboBox(string Tabla1,string Tabla2,string Campo1,int Id,string nombreID)
        {
            string[] Items = Sn.funcLlenarComboEspecifico(Tabla1,Tabla2,Campo1,Id,nombreID);
            return Items;
        }
    }
}
