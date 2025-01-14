public class Main
{
	public static void main(String[] args) {
		int [] ar = {1,2,3,4,5,6};
		int [] ar2 = {1,2,3,4,5,6};
		
		int[]res = new int[ar.length];
		
		for (int i = 0; i < ar.length; i++) {
                res[i] = ar[i] + ar2[i];
            }
            for (int i : res) {
                System.out.print(i + " ");
            }
            
	}
}
