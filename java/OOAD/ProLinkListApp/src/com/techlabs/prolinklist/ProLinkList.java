package com.techlabs.prolinklist;


public class ProLinkList<T> {
	
	private Node<T> firstNode;
	private Node<T> LastNode;
	private int size;
	
	public ProLinkList(){
		this.firstNode=null;
		this.LastNode=null;
	}
	

	
	public void add(Node<T> data){
		if(this.firstNode==null){
			this.firstNode=(Node<T>) data;
			this.LastNode=data;
		}else{
			this.LastNode.setNextLinkNode(data);
			this.LastNode=(Node<T>) data;
		}
		size++;
	}
	
	public boolean remove(int position){
		Node<T> current=this.firstNode;
		if(position>size){
			return false;
		}else if(this.firstNode.getNextLinkNode()==null){
			this.firstNode.setDataNode(null);
			return true;
			
		}else{
			for(int i=0;i<position-1;i++){
				current = current.getNextLinkNode();
			}
			current.setNextLinkNode(current.getNextLinkNode().getNextLinkNode());
			size--;
			return true;
		}
			
	}
	public T getNode(int  index){
		Node<T> current=this.firstNode;
		for(int i=0;i<index;i++){
			current = current.getNextLinkNode();
		}
		return current.getDataNode();
	}
	
	public int getSize(){
		return this.size;
	}
	

}
