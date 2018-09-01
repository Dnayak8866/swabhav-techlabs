package com.techlabs.frame.transaction;

import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class LoginEventListener implements ActionListener{
	private WelcomeFrame welcomeFrame;

	private JTextField userEmail;
	private JTextField userPass;
	public LoginEventListener(WelcomeFrame welcomeFrame,JTextField useremail,JTextField userPass) {
		this.userEmail=useremail;
		this.userPass=userPass;
		this.welcomeFrame=welcomeFrame;
	}
	@Override
	public void actionPerformed(ActionEvent event) {
		System.out.println(userEmail.getText());
		String email = userEmail.getText();
		String pass = userPass.getText();
		System.out.println(email);
		welcomeFrame.setUserEmailLabel("User :"+email);
		welcomeFrame.setUserPassLabel("Password :"+pass);
		welcomeFrame.getUserFrame().setVisible(true);
	}

}
