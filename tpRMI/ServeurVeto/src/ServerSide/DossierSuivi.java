package ServerSide;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;




public class DossierSuivi extends UnicastRemoteObject implements IDossierSuivi{

	
	private String description ;
	
	public DossierSuivi( String description )throws RemoteException{
		this.description = description ;
		
	}
	
	public String RecupererDossierSuivi(){
		return "Le dossier de suivi est : "+this.description ;
	}

	@Override
	public String modifierDossierSuivi( String DossierSuiviNv) {
		// TODO Auto-generated method stub
		return "le nouveau dossier de suivi de l'animal  est : "+DossierSuiviNv ;
		
	}
	

	

	public String getDescription() throws RemoteException {
		return description;
	}

	public void setDescription(String description) throws RemoteException {
		this.description = description;
	}



}
