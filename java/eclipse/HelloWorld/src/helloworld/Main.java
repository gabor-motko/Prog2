/**
 * 
 */
package helloworld;
/**
 * @author hallgato
 *
 */
public class Main
{

	/**
	 * @param args
	 */
	public static void main(String[] args)
	{
//		Person p1 = new Person("Gipsz Jakab", 38, true);
//		Person p2 = new Person();
//		Person p3 = new Person("Béla", 15, true);
//		
//		p2.setName("Apophis");
//		p2.setAge(5000);
//		
//		System.out.println(p1);
//		System.out.println(p2);
//		System.out.println(p3);
//		
//		Scanner s = new Scanner(System.in);
//		s.useLocale(new Locale("en"));
//		System.out.println(s.nextInt());
//		s.close();
		Hungarian h = new Hungarian();
		English e = new English();
		Communication t[] = new Communication[2];
		t[0] = h;
		t[1] = e;
		
		for(Communication p : t)
		{
		    p.hello("fucker");
		}
	}
}
