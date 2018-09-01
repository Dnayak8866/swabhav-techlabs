package com.techlabs.multiple.event.listener;

import java.awt.Container;

import javax.swing.JButton;
import javax.swing.JFrame;

import com.techlabs.buttons.RedButtonClickListener;

public class ButtonElementsFrame extends JFrame{
	public ButtonElementsFrame() {
		this.setTitle("ButtonClickEvent");
		this.setSize(1024,764);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setVisible(true);
		addButton();
	}

	private void addButton() {
		Container container = this.getContentPane();
		JButton redButton = new JButton("Red");
		JButton blueButton = new JButton("Blue");
		redButton.setBounds(250, 200, 200, 100);
		blueButton.setBounds(500, 200, 200, 100);
		blueButton.setVisible(true);
		redButton.setVisible(true);
		blueButton.setActionCommand("blue");
		redButton.setActionCommand("red");
		this.add(redButton);
		this.add(blueButton);
		
		redButton.addActionListener(new MultipleButtonEventListener(container));
		blueButton.addActionListener(new MultipleButtonEventListener(container));
	
	}
	
	
}
