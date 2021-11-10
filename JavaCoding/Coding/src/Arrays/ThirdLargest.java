package Arrays;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

public class ThirdLargest {
	public int function(int[] a, int n)
	{
		if(a.length < 3)
	    {
	        return -1;
	    }
	    List<Integer> list = new ArrayList<>();
	    for(int i = 0; i < n; i++)
	    {
	        list.add(a[i]);
	    }
	    Collections.sort(list);
	    return list.get(n-3);
	}
}
