package com.techlabs.buttons;

import java.awt.Container;

import javax.swing.JButton;
import javax.swing.JFrame;

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
		redButton.setBounds(200, 200, 100, 50);
		blueButton.setBounds(400, 200, 100, 50);
		blueButton.setVisible(true);
		this.add(redButton);
		this.add(blueButton);
		
		redButton.addActionListener(new RedButtonClickListener(container));
		blueButton.addActionListener(new BlueButtonClickListener(container));
	}
	

}
