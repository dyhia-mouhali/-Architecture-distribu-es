package ClientSide;
import java.rmi.Remote;
import java.rmi.RemoteException;


public interface ICabinet extends Remote {

	public IAnimal rechercheAnimal (String nom) throws RemoteException;
	public Boolean ajouterAnimal (IAnimal a ) throws RemoteException;
	public IAnimal createAnimal(int AnimalID ,String nom , String nom_maitre , String race , Espece espece) throws RemoteException ;
}
