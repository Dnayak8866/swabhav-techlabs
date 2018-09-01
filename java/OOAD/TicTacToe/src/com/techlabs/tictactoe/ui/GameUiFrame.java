package com.techlabs.tictactoe.ui;

import java.awt.Component;
import java.awt.Container;
import java.awt.Dimension;
import java.awt.FlowLayout;
import java.awt.GridLayout;
import java.awt.LayoutManager;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JPanel;
import javax.swing.JTextField;

import com.techlabs.tictactoe.Board;
import com.techlabs.tictactoe.Game;
import com.techlabs.tictactoe.GameStatus;
import com.techlabs.tictactoe.Mark;
import com.techlabs.tictactoe.Player;
import com.techlabs.tictactoe.Players;
import com.techlabs.tictactoe.ResultAnalyzer;

public class GameUiFrame extends JFrame implements ActionListener  {
	private JFrame gameFrame;
	private JButton button;
	private JTextField playerOne;
	private JTextField playerTwo;
	private Player player1,player2;
	private GamePlayerFrameUi gamePlayerFrameUi;
	private JLabel whoseTurnLabel; 
	private Game game;
	private Board gameBoard = new Board(3, 3);
	private ResultAnalyzer analyser=new ResultAnalyzer(gameBoard);
	private JPanel gameboxPanel = new JPanel();
	private JLabel gameStatusLabel;
	private JLabel winnerLabel;
	
	public GameUiFrame() {
		
	}
	public GameUiFrame(GamePlayerFrameUi gamePlayerUi,JTextField player1,JTextField player2) {
		this.playerOne=player1;
		this.playerTwo=player2;
		this.gamePlayerFrameUi=gamePlayerUi;
		
		
	}
	@Override
	public void actionPerformed(ActionEvent arg0) {
		createGameUI();
		
	}

	private void createGameUI() {
		this.gameFrame= new JFrame();
		gameFrame.setLayout(new GridLayout(5,1));
		
		gameStatusLabel = new JLabel();
		gameStatusLabel.setText("Game staus");
		gameStatusLabel.setHorizontalAlignment(gameStatusLabel.CENTER);
		
		JPanel gamestatusPanel = new JPanel();
		gamestatusPanel.add(gameStatusLabel);
		gamestatusPanel.setLayout(new FlowLayout());
		
		JLabel playerOneName = new JLabel();
		playerOneName.setText("Player one :"+this.playerOne.getText());
		playerOneName.setHorizontalAlignment(playerOneName.CENTER);
		
		JLabel playerTwoName = new JLabel();
		playerTwoName.setText("Player two :"+this.playerTwo.getText());
		playerTwoName.setHorizontalAlignment(playerTwoName.CENTER);
		
		JPanel playerNamePanel = new JPanel();
		playerNamePanel.add(playerOneName);
		playerNamePanel.add(playerTwoName);
		playerNamePanel.setLayout(new GridLayout(2,1));
		
		
		whoseTurnLabel = new JLabel();
		
		whoseTurnLabel.setHorizontalAlignment(playerTwoName.CENTER);
		
		JPanel whoseTurnPannel = new JPanel();
		whoseTurnPannel.add(whoseTurnLabel);
		whoseTurnPannel.setLayout(new FlowLayout());
		
		Integer position = 1;
		for(Integer i=0;i<9;i++,position++){
		
			JButton button = new JButton(position.toString());
			button.setName(position.toString());
			button.addActionListener(new ActionListener() {
				
				@Override
				public void actionPerformed(ActionEvent arg0) {
					int position=Integer.parseInt(button.getName());
					if(game.getGameStatus()==GameStatus.ONGOING){
						gamePlay(position);
						button.setText(game.getCurrentPlayer().getMark().toString());
					}
					
					
					
				}
			});
			this.gameboxPanel.add(button);
			gameboxPanel.setSize(100,100);
			gameboxPanel.setLayout(new GridLayout(3,3));
		}
		
		
		
		
		
		JPanel winnerPanel = new JPanel();
		winnerLabel = new JLabel();
		winnerLabel.setText("Wiiner name");
		winnerPanel.add(winnerLabel);
		winnerPanel.setLayout(new FlowLayout());
		
		
		gameFrame.add(gamestatusPanel);
		gameFrame.add(playerNamePanel);
		gameFrame.add(whoseTurnPannel);
		gameFrame.add(gameboxPanel);
		gameFrame.add(winnerPanel);
		
		gameFrame.setSize(400,400);
		gameFrame.setVisible(true);
		
		startGame();
	}
	
	protected void gamePlay(int position) {
		this.game.play(position);
		whoseTurnLabel.setText("Current player :"+game.getPlayerTurn().getName()+" Mark :"+game.getPlayerTurn().getMark());
		gameStatusLabel.setText("Gamestatus :"+game.getGameStatus());
		if (game.getGameStatus() == GameStatus.WON) {
			gameStatusLabel.setText("Gamestatus :"+game.getGameStatus());
			winnerLabel.setText(game.getCurrentPlayer().getName()+" Wins...");
		}else if(game.getGameStatus() == GameStatus.DRAW) {
			gameStatusLabel.setText("Gamestatus :"+game.getGameStatus());
			winnerLabel.setText("Game is Draw.....");
		}
	}
	private void startGame() {
		this.player1 = new Player(this.playerOne.getText(),Mark.CROSS);
		this.player2 = new Player(this.playerTwo.getText(), Mark.NOUGHT);
		game= new Game(analyser, gameBoard,this.player1,this.player2);

		whoseTurnLabel.setText("Current player :"+game.getPlayerTurn().getName()+"Mark :"+game.getPlayerTurn().getMark());
		
		
	}
	
	

	
	
	
	

	
}
