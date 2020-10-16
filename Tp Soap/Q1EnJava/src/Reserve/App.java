package Reserve;

import java.util.ArrayList;
import java.util.Date;
import java.util.Scanner;
import java.io.ObjectInputStream.GetField;
import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;

public class App {

	public static void main(String[] args) throws ParseException {
		// TODO Auto-generated method stub

		// Adresses :
		Adresse adrHotel = new Adresse("France", "marseille",
				"35 Rue Montgrand", "Hôtel Maison Montgrand", 13006);
		Adresse adrHote2 = new Adresse("France", "montpellier",
				"200 avenue vert bois", "Hôtel ver tbois", 34090);

		// Hotels :
		Hotel hotel1 = new Hotel("Hôtel Maison Montgrand", adrHotel, 4);
		Hotel hotel2 = new Hotel("HotelLaComédie", adrHote2, 5);

		// type de chambre
		TypeChambre typeCh1 = new TypeChambre(60, 1);
		TypeChambre typeCh2 = new TypeChambre(120, 2);
		TypeChambre typeCh3 = new TypeChambre(150, 3);

		// les date des chambres de l'hotel1
		Date datechambr1eMars = new Date(2020, 02, 01);
		Date datechambr1eMarsfindisp = new Date(2020, 06, 15);
		Date datechambr2eMars = new Date(2020, 03, 20);
		Date datechambr2eMarsefindisp = new Date(2020, 06, 25);
		Date datechambr3eMars = new Date(2020, 11, 20);
		Date datechambr3eMarsfindisp = new Date(2021, 05, 25);

		// les date des chambre de l'hote2
		Date datechambr1eMont = new Date(2020, 01, 01);
		Date datechambr1eMontfindisp = new Date(2020, 06, 15);
		Date datechambr2eMont = new Date(2020, 04, 20);
		Date datechambr2eMontfindisp = new Date(2020, 07, 25);
		Date datechambr3eMont = new Date(2020, 12, 20);
		Date datechambr3eMontfindisp = new Date(2021, 07, 25);

		// les chambres de l'hotel1 :
		Chambre chambre1Hotel1 = new Chambre(typeCh1, datechambr1eMars,
				datechambr1eMarsfindisp);
		Chambre chambre2Hotel1 = new Chambre(typeCh2, datechambr2eMars,
				datechambr2eMarsefindisp);
		Chambre chambre3Hotel1 = new Chambre(typeCh3, datechambr3eMars,
				datechambr3eMarsfindisp);

		// les chambres de l'hotel2 :
		Chambre chambre1Hotel2 = new Chambre(typeCh1, datechambr1eMont,
				datechambr1eMontfindisp);
		Chambre chambre2Hotel2 = new Chambre(typeCh2, datechambr2eMont,
				datechambr2eMontfindisp);
		Chambre chambre3Hotel2 = new Chambre(typeCh3, datechambr3eMont,
				datechambr3eMontfindisp);

		// Ajout des chambre a leur hotels
		hotel1.addChambre(chambre1Hotel1);
		hotel1.addChambre(chambre2Hotel1);
		hotel1.addChambre(chambre3Hotel1);
		hotel2.addChambre(chambre1Hotel2);
		hotel2.addChambre(chambre2Hotel2);
		hotel2.addChambre(chambre3Hotel2);
		System.out.println("Ajout des chambre au hotels est reussit");

		// ajout des hotels
		ArrayList<Hotel> listHotel = new ArrayList<>();
		RechercheHotel rech = new RechercheHotel();
		rech.add(hotel1);
		rech.add(hotel2);
		System.out.println("l'ajout des hotels est reussit ");

		// les informations saisie parl l'utlisateur

		System.out
				.println("veuillez mentionner votre choix de ville ou vous souhate séjourner ");

		java.util.Scanner entree = new java.util.Scanner(System.in);
		String villeSouhaite = entree.next();
		
		

		System.out
				.println("Saisissez une date d'arrive sous cette forme  (JJ/MM/AAAA) :");

		Scanner sc = new java.util.Scanner(System.in);
		String strdateArrive = sc.next();
		if (strdateArrive.matches("[0-9]{2}/[0-9]{2}/[0-9]{4}")) {
			Date datearrive=new SimpleDateFormat("jj/MM/aaaa").parse(strdateArrive); 
		}else {
			System.out.println("Erreur format");
		}
			  
			  
			  
			  
		System.out
				.println("Saisissez une date de de retour sous cette forme  (JJ/MM/AAAA) :");
		Scanner sc2 = new java.util.Scanner(System.in);
		String strdateretour = sc2.next();
		System.out.println(strdateretour);
		
		if (strdateretour.matches("[0-9]{2}/[0-9]{2}/[0-9]{4}")) {
			 Date dateretour=new SimpleDateFormat("jj/MM/aaaa").parse(strdateretour);
		
		} else {
			System.out.println("Erreur format");
		}
		
		
		
		
		
		System.out.println("veuillez saisir votre prix min");
		java.util.Scanner entreeprixmin = new java.util.Scanner(System.in);
		int prixMin = entreeprixmin.nextInt();

		System.out.println("veuillez saisir votre prix max");
		java.util.Scanner entreeprixmax = new java.util.Scanner(System.in);
		int prixMax = entreeprixmax.nextInt();

		System.out.println("veuillez saisir le nombre d'etoile :");
		java.util.Scanner entreenombreEtoile = new java.util.Scanner(System.in);
		int nombreEtoile = entreenombreEtoile.nextInt();

		System.out.println("veuillez saisir le nombre de perssonne");
		java.util.Scanner entreenombrePersonne = new java.util.Scanner(
				System.in);
		int nombrePersonne = entreenombrePersonne.nextInt();

		//
		listHotel = rech.rechercherHotel(villeSouhaite, datearrive, dateretour,
				prixMin, prixMax, nombreEtoile, nombrePersonne);
		for (Hotel hotel : listHotel) {
			System.out.println("le nom de l'hotel est :" + hotel.nom);
		}
		if (listHotel.isEmpty()) {
			System.out
					.println("il y a aucun des hotels qui vous correspondrent ");
		} else {
			// parcourir arraylist pour extraire l'hotaile corres
			System.out.println("les hots qui vous correspondent :");
			for (Hotel h : listHotel) {
				System.out.println("le nom de l'hotel : " + h.nom);
				System.out.println("le nombre d'etoile de l'hotel "
						+ h.getNombreEtoile());
				System.out.println("l'adresse del'hotel est :"
						+ h.getAdresse().getPays() + " "
						+ h.getAdresse().getVille() + " "
						+ h.getAdresse().getRue() + " "
						+ h.getAdresse().getNumero() + " "
						+ h.getAdresse().getLieu_dit());
				for (Chambre ch : h.chambres) {
					System.out.println("le prix de la chambre "
							+ ch.getTypeChambre().getPrixBase()
							+ " le nombre de lits dans la chambre "
							+ ch.getTypeChambre().getNbrLits());
				}

			}

		}

		String votreChoix, nomClient, prenomClient, dateExpiration;
		int age, numetel, numeroCarte, code;
		Reservation reserve = new Reservation();

		System.out
				.println("si vous shouaite passer a la reserveation entre le nom de l'hotel qui vous plait sion retour");
		java.util.Scanner entrechoix = new java.util.Scanner(System.in);
		votreChoix = entrechoix.next();
		if (!votreChoix.equals("retour")) {
			System.out
					.println("vouliez entre vous corrdonnees: Nom , Prenom, Age, muero de telephone ");
			java.util.Scanner entrenom = new java.util.Scanner(System.in);
			nomClient = entrenom.next();

			java.util.Scanner entreprenom = new java.util.Scanner(System.in);
			prenomClient = entreprenom.next();

			java.util.Scanner entreage = new java.util.Scanner(System.in);
			age = entreage.nextInt();

			java.util.Scanner entrenumtel = new java.util.Scanner(System.in);
			numetel = entrenumtel.nextInt();

			System.out.println("passons au payment par carte bancaire ");
			System.out.println("entre votre numero de carte bancaire ");
			java.util.Scanner entrenumcart = new java.util.Scanner(System.in);
			numeroCarte = entrenumcart.nextInt();
			System.out.println("votre date d'expirattion");
			java.util.Scanner entredateExpr = new java.util.Scanner(System.in);
			dateExpiration = entredateExpr.next();
			System.out.println("entre votre code ");
			java.util.Scanner entrecode = new java.util.Scanner(System.in);
			code = entrecode.nextInt();

			Client client = new Client(nomClient, prenomClient, age, numetel);
			reserve.reserver(client);
			System.out.println("reservation aavec sucess");

		}

	}

}
