import java.rmi.Remote;
import java.rmi.RemoteException;

public interface IVeterinaire extends Remote {

    void Alert(String alert) throws RemoteException;

}
