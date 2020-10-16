package ServerSide;
import java.rmi.Remote;
import java.rmi.RemoteException;


public interface IDossierSuivi extends Remote{

	public String RecupererDossierSuivi() throws RemoteException ;
	public String modifierDossierSuivi( String DossierSuiviNv) throws RemoteException;
}
