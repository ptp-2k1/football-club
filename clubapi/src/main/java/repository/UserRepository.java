package repository;

import java.util.List;
import java.util.Optional;

import org.springframework.jdbc.core.simple.JdbcClient;
import org.springframework.util.Assert;

import dto.User;

public class UserRepository {
	
	private final JdbcClient jdbcClient;
	
	public UserRepository(JdbcClient jdbcClient) {
		this.jdbcClient = jdbcClient;
	}
	
	public Optional<User> findById(Integer id) {
		return this.jdbcClient.sql("SELECT FROM Users WHERE id = :id")
				.query(User.class)
				.optional();
	}
	
	public void create(User user) {
		int created = this.jdbcClient.sql("INSERT INTO Users(id, userName, password) VALUES (?, ?, ?)")
		.params(List.of(user.getId(), user.getUserName(), user.getPassword()))
		.update();
		
		Assert.state(created == 1 ? true : false, "Failed to create this user");
	}
}
