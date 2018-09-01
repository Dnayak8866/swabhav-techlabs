package com.techlabs.frame.transaction;

import java.awt.FlowLayout;
import java.awt.Frame;
import java.awt.GridLayout;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class WelcomeFrame extends Frame {
	private JFrame userFrame = new JFrame("Welcome");
	private JFrame loginFrame = new JFrame("Login");

	private JTextField emailTextField;
	private JTextField passTextField;

	private JLabel userEmailLabel;
	private JLabel userPassLabel;

	public WelcomeFrame() {
		setupLoginFrame();
		setupUserFrame();
	}

	private void setupUserFrame() {

		userFrame.setDefaultCloseOperation(userFrame.EXIT_ON_CLOSE);
		userFrame.setLayout(new FlowLayout());
		userFrame.setSize(1024, 764);

		userEmailLabel = new JLabel();
		userPassLabel = new JLabel();
		userFrame.add(userEmailLabel);
		userFrame.add(userPassLabel);

	}

	private void setupLoginFrame() {

		loginFrame.setDefaultCloseOperation(loginFrame.EXIT_ON_CLOSE);
		loginFrame.setLayout(new FlowLayout());
		loginFrame.setSize(1024, 764);

		emailTextField = new JTextField("enter email",20);
		passTextField = new JTextField(20);

		JButton loginButton = new JButton("login");
		loginButton.setBounds(250, 200, 500, 500);
		emailTextField.setBounds(500, 200, 200, 100);

		loginFrame.add(emailTextField);
		loginFrame.add(passTextField);
		loginFrame.add(loginButton);
		loginFrame.setVisible(true);

		loginButton.addActionListener(new LoginEventListener(this, emailTextField,passTextField));

	}

	public JTextField getEmailTextField() {
		return this.emailTextField;
	}

	public JFrame getUserFrame() {
		return this.userFrame;
	}

	public void setUserEmailLabel(String text) {
		this.userEmailLabel.setText(text);
	}
	public void setUserPassLabel(String text) {
		this.userPassLabel.setText(text);
	}
	
	public JLabel getUserEmailLabel() {
		return this.userEmailLabel;
	}

}
