package ClientSide;

import java.rmi.Remote;
import java.rmi.RemoteException;

public interface  IVeterinairee extends Remote{

	  public void Alert(String alert) throws RemoteException ;
}
