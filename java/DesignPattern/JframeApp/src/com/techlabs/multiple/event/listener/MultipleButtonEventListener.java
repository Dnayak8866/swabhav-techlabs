package com.techlabs.multiple.event.listener;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;

public class MultipleButtonEventListener implements ActionListener{
	Container frame ;

	public MultipleButtonEventListener(Container frame) {
		this.frame=frame;
	}

	@Override
	public void actionPerformed(ActionEvent event) {
		JButton button =(JButton) event.getSource();
		String actionCommand=button.getActionCommand();
		if(actionCommand.equalsIgnoreCase("red")){
			frame.setBackground(Color.RED);
		}else{
			frame.setBackground(Color.BLUE);
		}
		
	}

}
