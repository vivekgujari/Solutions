package Arrays;
import java.util.*;
public class PythogreanTriplet {
	public boolean exists(int[] arr)
	{
		if(arr.length < 3)
			return false;
		Arrays.sort(arr);
		int i = 0;
		int j = 1;
		int k = 2;
		while(j < arr.length - 1)
		{
			if(arr[i]*arr[i] + arr[j] * arr[j] == arr[k] * arr[k])
				return true;
			if(arr[i]*arr[i] + arr[j] * arr[j] > arr[k] * arr[k])
			{
				k++;
			}
			else
			{
				i++;
				j++;
				k++;
			}
		}
		return false;
	}
}
