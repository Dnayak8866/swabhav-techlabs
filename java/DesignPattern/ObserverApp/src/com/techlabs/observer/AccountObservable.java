package com.techlabs.observer;

public interface AccountObservable {
	public void addListener(BalanceChangeListener listener);
	public void removeListener(BalanceChangeListener listener);

}
