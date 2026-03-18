using System.Data.SQLite;
using System;
using System.IO;

namespace Lam7ara{
    internal class Conectar {



        private static string pathDB = Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Lam7araDataBaseAPP.db");
        private static string cadena = $"Data Source={Path.Combine(AppDomain.CurrentDomain.GetData("DataDirectory").ToString(), "Lam7araDataBaseAPP.db")};";

        private static string cadenaAppData = $"Data Source={Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lam7ara", "Lam7araDataBaseAPP.db")};Version=3;"; 
        private static string pathDBAppData = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lam7ara", "Lam7araDataBaseAPP.db");
        private static string BackUp = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "BackUpLam7ara", "Lam7araDataBaseAPP.db");

        public string datos = string.Empty;

        public static void Comprobar() {
            string folderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lam7ara");

            if(!Directory.Exists(folderPath)) {
                Directory.CreateDirectory(folderPath);
                Console.WriteLine("La carpeta no existía, fue creada con éxito");
            }
            Console.WriteLine("Carpeta encontrada con éxito");

            string lam7araFolderPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Lam7ara");

            if(!Directory.Exists(lam7araFolderPath)) {
                Directory.CreateDirectory(lam7araFolderPath);
                Console.WriteLine("La carpeta 'Lam7ara' no existía, fue creada con éxito");
            }

            if(!File.Exists(pathDBAppData)) {
                if(File.Exists(pathDB)) {
                    File.Copy(pathDB, pathDBAppData, true);
                    Console.WriteLine("Base de datos copiada correctamente a AppData.");
                } else {
                    Console.WriteLine("El archivo de base de datos original no se encuentra en la ruta especificada.");
                }
            }

            
        }
        public static string CrearBackUp() {
            try {
                string backupFolderPath = Path.GetDirectoryName(BackUp);

                if(!Directory.Exists(backupFolderPath)) {
                    Directory.CreateDirectory(backupFolderPath);
                    Console.WriteLine("La carpeta de respaldo no existía, fue creada con éxito");
                }


                if(!File.Exists(BackUp)) {

                    if(File.Exists(pathDBAppData)) {
                        File.Copy(pathDBAppData, BackUp, true);
                    } else {
                        Console.WriteLine("El archivo no se encuentra en ruta especificada");
                    }
                    Console.WriteLine("backUpCreado");

                } else {


                }

            } catch(Exception ex) {

                Console.WriteLine("HUBO UN ERROR" + ex);
                return "error";
            }

            return BackUp;
        }
        public static SQLiteConnection ObtenerConexion() {
            try {
                string cadenaConexion = cadenaAppData;
                var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();

                return conexion;

            } catch(Exception ex) {
                Console.WriteLine($"Error al obtener la conexión: {ex.Message}");
                throw;
            }
        }


    }
}