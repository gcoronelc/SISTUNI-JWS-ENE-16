
/**
 * Please modify this class to meet your needs
 * This class is not complete
 */

package pe.mcg.ws.service;
import javax.xml.namespace.QName;
import javax.xml.ws.Service;
import javax.xml.ws.soap.SOAPBinding;

/**
 * This class was generated by Apache CXF 2.7.18
 * 2016-02-21T11:12:27.211-05:00
 * Generated source version: 2.7.18
 * 
 */
public class UsuarioServiceClient {

    public static void main(String[] args) throws Exception {
        QName serviceName = new QName("service.ws.mcg.pe", "UsuarioServiceImplService");
        QName portName = new QName("service.ws.mcg.pe", "UsuarioServiceImplPort");

        Service service = Service.create(serviceName);
        service.addPort(portName, SOAPBinding.SOAP11HTTP_BINDING,
                        "http://localhost:9090/UsuarioServiceImplPort"); 
        pe.mcg.ws.service.UsuarioService client = service.getPort(portName,  pe.mcg.ws.service.UsuarioService.class);
        
        // Insert code to invoke methods on the client here
    }

}