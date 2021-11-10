package Arrays;

import java.util.ArrayList;
import java.util.List;

public class Alternate_pos_neg {
	public void rearrange(int arr[], int n) {
        // code here
        List<Integer> l1 = new ArrayList<>();
        List<Integer> l2 = new ArrayList<>();
        for(int i = 0; i < arr.length; i++)
        {
            if(arr[i] >= 0)
            {
                l1.add(arr[i]);
            }
            else
            {
                l2.add(arr[i]);
            }
        }
        int j = 0;
        int k = 0;
        int i = 0;
        for(i = 0; i < n; i++)
        {
        	if(j == l1.size() || k == l2.size())
        		break;
            if(i % 2 == 0)
            {
                arr[i] = l1.get(j++);
            }
            else if(i % 2 == 1)
            {
                arr[i] = l2.get(k++);
            }
        }
        while(j < l1.size())
        {
        	arr[i++] = l1.get(j++);
        }
        while(k < l2.size())
        {
        	arr[i++] = l2.get(k++);
        }
        
    }
}
