package com.techlabs.jframe;

import java.awt.Color;
import java.awt.Container;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;

public class WelcomeFrame extends JFrame {
	public WelcomeFrame() {
		
		this.setTitle("Welcome Frame");
		this.setSize(1024,764);
		this.setDefaultCloseOperation(EXIT_ON_CLOSE);
		this.setVisible(true);
		addButton();
	}


	private void addButton() {
		Container container = this.getContentPane();
		JButton button = new JButton("Click me");
		button.setBounds(200, 200, 100, 50);
		button.setVisible(true);
		this.add(button);
		
		button.addActionListener(new ActionListener() {
			
			@Override
			public void actionPerformed(ActionEvent arg0) {
				container.setBackground(Color.GREEN);
				
			}
		});
		
	}
}
