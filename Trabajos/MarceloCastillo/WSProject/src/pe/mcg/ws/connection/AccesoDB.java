package pe.mcg.ws.connection;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.SQLException;

import pe.mcg.ws.utils.Constantes;

public class AccesoDB {

	private AccesoDB() {
	  }

	  public static Connection getConnection() throws SQLException {
	    Connection cn = null;
	    try {
	      // Datos MySQL
	      //String driver = "com.mysql.jdbc.Driver";
	      //String url = "jdbc:mysql://localhost:3306/EUREKABANK";
	      //String url = "jdbc:mysql://192.168.1.166:3306/usuarios";
	      //String user = "root";
	      //String pass = "mysql";
	      
	      String driver = Constantes.jdbc_driver;
	      String url = Constantes.jdbc_url;
	      String user = Constantes.jdbc_username;
	      String pass = Constantes.jdbc_password;
	      
	      // Cargar el driver a memoria
	      Class.forName(driver).newInstance();
	      // Obtener el objeto Connection
	      cn = DriverManager.getConnection(url, user, pass);
	    } catch (SQLException e) {
	      throw e;
	    } catch(ClassNotFoundException e){
	      throw new SQLException("ERROR, no se encuentra el driver.");
	    } catch(Exception e){
	      throw new SQLException("ERROR, no se tiene acceso al servidor.");
	    }
	    return cn;
	  }
	
}
