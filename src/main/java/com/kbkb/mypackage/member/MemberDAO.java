package com.kbkb.mypackage.member;

import org.springframework.stereotype.Repository;

@Repository
public class MemberDAO {

	private int test;

	public int getTest() {
		return test;
	}

	public void setTest(int test) {
		this.test = test;
	}
	
}
