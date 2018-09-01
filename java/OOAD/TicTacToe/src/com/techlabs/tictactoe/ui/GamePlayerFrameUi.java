package com.techlabs.tictactoe.ui;

import java.awt.Dimension;
import java.awt.GridLayout;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.GroupLayout;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.Players;

public class GamePlayerFrameUi extends JFrame {
	
	private JFrame playerFrame;
	Players<Player> players;
	private Player player1,player2;
	public GamePlayerFrameUi() {
		this.players=null;
		
		makeUi();
	}

	private void makeUi() {
		//playerFrame.setSize(1024, 764);
		this.playerFrame = new JFrame("Player");
		playerFrame.setDefaultCloseOperation(playerFrame.EXIT_ON_CLOSE);
		playerFrame.setBounds(500, 500, 1000, 700);
		JLabel header = new JLabel();
		header.setText("......Lets play Tic-Tac-Toe........");
		header.setHorizontalAlignment(header.CENTER);
		
		
		JLabel playerXLabel = new JLabel("Player-X");
		JTextField playerXNameField = new JTextField();
		playerXNameField.setSize(getMinimumSize());
		playerXLabel.setHorizontalAlignment(playerXLabel.CENTER);
		
		JLabel playerOLabel = new JLabel("Player-O");
		playerOLabel.setHorizontalAlignment(playerOLabel.CENTER);
		JTextField  playerONameField= new JTextField();
		
		
		playerONameField.setMinimumSize(getMaximumSize());
		JButton startButton = new JButton("Start Game");
		startButton.setBounds(100, 100, 150, 100);
		
		startButton.addActionListener(new GameUiFrame(this,playerXNameField,playerONameField));
		
		
		JPanel playerPanel = new JPanel();
		playerPanel.setPreferredSize(new Dimension(500,500));
		playerPanel.add(header);
		playerPanel.add(playerXLabel);
		playerPanel.add(playerXNameField);
		playerPanel.add(playerOLabel);
		playerPanel.add(playerONameField);
		playerPanel.add(startButton);
		playerPanel.setLayout(new GridLayout(6,1));
		
		playerFrame.add(playerPanel);
		playerFrame.pack();
		playerFrame.setVisible(true);	
		
	
	}
	
	
	
	
	
	

}
