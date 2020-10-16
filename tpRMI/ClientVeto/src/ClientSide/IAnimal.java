package ClientSide;
import java.rmi.Remote;
import java.rmi.RemoteException;


public interface IAnimal extends Remote{

	public String afficher_nomAnimal() throws RemoteException;
	public String consulterEspece() throws RemoteException ;
	public String getNom()throws RemoteException ;
}
