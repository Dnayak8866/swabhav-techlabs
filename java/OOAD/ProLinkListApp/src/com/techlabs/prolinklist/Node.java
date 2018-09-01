package com.techlabs.prolinklist;



public class Node<T> {
	
	private T dataNode;
	private Node nextNode;
	public Node(){
		this.dataNode=null;
		this.nextNode=null;
	}
	public Node(T data) {
		this.dataNode = data;
		this.nextNode=null;	
	}
	
	public void setDataNode(T data){
		this.dataNode=data;
	}
	
	public void setNextLinkNode(Node<T> node){
		this.nextNode=node;
	}
	
	public T getDataNode(){
		return this.dataNode;		
	}
	public Node<T> getNextLinkNode(){
		return this.nextNode;
	}
	
}
