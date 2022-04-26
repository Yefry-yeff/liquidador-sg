using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Data;
using System.Xml.Serialization;
using System.Data.Common;
using Oracle.DataAccess.Client;
using System.Diagnostics;

namespace comprobacion.clases
{
    public class dbOracle
    {

        public OracleConnection vConexion;

        public dbOracle()
        {
            vConexion = new OracleConnection(ConfigurationManager.AppSettings["PROD"]);
        }

        public DataTable ObtenertDataTable(String vQuery)
        {
            DataTable vDatos = new DataTable();

            try
            {
                OracleDataAdapter vDataAdapter = new OracleDataAdapter(vQuery, vConexion);
                vDataAdapter.SelectCommand.CommandTimeout = 50000;
                vDataAdapter.Fill(vDatos);
            }
            catch (Exception)
            {

            }

            return vDatos;
        }

        public DataSet obtenerDataSet(String vQuery) {

            DataSet vDatos = new DataSet();

            try
            {
                OracleDataAdapter vDataAdapter = new OracleDataAdapter(vQuery, vConexion);
                vDataAdapter.Fill(vDatos);
            }
            catch(Exception)
            {

            }

            return vDatos;
        }

        public int ejecutarSql(String vQuery)
        {
            int vResultado = 0;

            try
            {
                OracleCommand vSqlCommand = new OracleCommand(vQuery, vConexion);
                vSqlCommand.CommandType = CommandType.Text;
                vSqlCommand.CommandTimeout = 50000;

                vConexion.Open();
                vResultado = vSqlCommand.ExecuteNonQuery();
                vConexion.Close();
            }
            catch
            {
                vConexion.Close();
            }

            return vResultado;

        }

        public DataTable obtenerConsultas(string consulta, params object[] Datos)
        {
            DataTable dt = new DataTable();

             OracleDataAdapter da;

            OracleConnection con = new OracleConnection(ConfigurationManager.AppSettings["PROD"]);
            OracleCommand miComando = new  OracleCommand();
            miComando = con.CreateCommand();

            String Procedimiento = "";
            String PaqueteInterno;

            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                return dt;
            }

            PaqueteInterno = "SCHON.PKG_FACTURADOR";

            switch (consulta)
            {
                case "diferenciaCHAP1":
                    miComando.Parameters.Add("periodo", OracleDbType.Int64, Convert.ToInt64(Datos[1]), ParameterDirection.Input);
                    miComando.Parameters.Add("cicloComp", OracleDbType.Int64, Convert.ToInt64(Datos[0]), ParameterDirection.Input);
                    Procedimiento = "SP_diferenciasFAC_INCMS_CHAP_1";

                    break;

                case "spReCalcular":
                    miComando.Parameters.Add("anio", OracleDbType.Int64, Convert.ToInt64(Datos[0]), ParameterDirection.Input);
                    miComando.Parameters.Add("periodo", OracleDbType.Int64, Convert.ToInt64(Datos[1]), ParameterDirection.Input);
                    miComando.Parameters.Add("dial", OracleDbType.Int64, Convert.ToInt64(Datos[2]), ParameterDirection.Input);
                    Procedimiento = "SP_ReCalcular_Dial";

                    break;

                case "resumenCiclos":
                    miComando.Parameters.Add("cicloComp", OracleDbType.Int64, Convert.ToInt64(Datos[0]), ParameterDirection.Input);
                    Procedimiento = "SP_resumenCiclos";

                    break;

                case "diferencisConceptos":
                    miComando.Parameters.Add("cicloComp", OracleDbType.Int64, Convert.ToInt64(Datos[0]), ParameterDirection.Input);
                    Procedimiento = "SP_diferencisConceptos";

                    break;

                case "dataActualizadaSP":
                    Procedimiento = "SP_DATA_ACTUALIZADA_MES_ACTUAL";

                    break;

                    
            }

            miComando.Parameters.Add("o_cursor",  OracleDbType.RefCursor, ParameterDirection.Output);
            miComando.CommandText = PaqueteInterno + "." + Procedimiento;
            miComando.CommandType = CommandType.StoredProcedure;

            try
            {
                da = new  OracleDataAdapter(miComando);
                da.Fill(dt);
            }
            catch(Exception ex)
            {
            }

            con.Close();
            da=null;

            return dt;
        }

        public DataTable stam(String xml)
        {
            StringReader theReader = new StringReader(xml);
            DataSet theDataSet = new DataSet();

            return theDataSet.Tables[0];
        }

    }

}
