package ServerSide;
import java.io.Serializable;
import java.rmi.RemoteException;
import java.rmi.server.UnicastRemoteObject;





public class Animal extends UnicastRemoteObject implements IAnimal, Serializable {

	
	private static final long serialVersionUID = 1L;
	private int AnimalID ;
	private String nom ;
	private String nom_maitre;
	private String race ;
	private String nom_espece ;
//	private DossierSuivi dossier ;
	private Espece espece ;
	
	public Animal (int AnimalID ,String nom , String nom_maitre , String race , Espece espece2 ) throws RemoteException{
		this.AnimalID=AnimalID ; //this.dossier=dossier ;
		this.nom=nom ; this.nom_maitre = nom_maitre ; this.race=race ; this.espece= espece2 ;
	}

	public Animal() throws RemoteException{
		
	}
	
	public String afficher_nomAnimal() throws RemoteException{
		return "le nom complet de cet animal est : "+this.getNom()+ " le nom de son maitre est : "+this.getNom_maitre()+
				 " et sa race est "+this.getRace()+" et son identifiant est :"+this.AnimalID;
	}
	
	
	
	@Override
	public String consulterEspece() throws RemoteException {
		// TODO Auto-generated method stub
		return espece.getEspece();
	}
	
	public int getID() throws RemoteException{
		return AnimalID ;
	}
	
	public void setID(int id) throws RemoteException{
		this.AnimalID=id ;
	}
	@Override
	public String getNom() throws RemoteException {
		return nom;
	}

	public void setNom(String nom) throws RemoteException {
		this.nom = nom;
	}

	public String getNom_maitre() throws RemoteException {
		return nom_maitre;
	}

	public void setNom_maitre(String nom_maitre)throws RemoteException {
		this.nom_maitre = nom_maitre;
	}

	public String getRace()throws RemoteException {
		return race;
	}

	public void setRace(String race)throws RemoteException {
		this.race = race;
	}

	public String getNom_espece() throws RemoteException{
		return nom_espece;
	}

	public void setNom_espece(String nom_espece)throws RemoteException {
		this.nom_espece = nom_espece;
	}

public Espece getEspece (Espece e){
	return e ;
}

	
	
	
}
