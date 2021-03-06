package LinkedList;

public class LinkedList {	
	Node head = null;
	Node tail = null;
	int size = 0;
	// adds node to end of the list
	public void add(Node item)
	{
		if(head == null)
		{
			head = tail = item;
			size++;
			return;
		}
		Node temp = head;
		while(temp.next != null)
		{
			temp = temp.next;
		}
		temp.next = item;
		tail = temp;
		size++;
	}
	
	public void addFirst(Node item)
	{
		if(head == null)
		{
			head = tail = item;
			size++;
			return;
		}
		item.next = head;
		head = item;
		size++;
	}
	
	public void addLast(Node item)
	{
		if(head == null)
		{
			head = tail = item;
			size++;
			return;
		}
		tail.next = item;
		tail = item;
		size++;
	}
	
	public int size()
	{
		return size;
	}
	
	public boolean isEmpty()
	{
		return size == 0;
	}
	
	public void add(int index, Node item)
	{
		if(index > size)
		{
			throw new IllegalArgumentException("index is greater than the size of list");
		}
		Node temp = head;
		int i = 0;
		while(i < index)
		{
			temp = temp.next;
		}
		item.next = temp.next;
		temp.next = item;
	}
	
	public Node reverse()
	{
		Node current = this.head;
		Node next = null;
		Node prev = null;
		while(current != null)
		{
			next = current.next;
			current.next = prev;
			prev = current;
			current = next;
		}
		return prev;
	}
}
