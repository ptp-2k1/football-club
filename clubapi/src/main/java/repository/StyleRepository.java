package repository;

import java.util.ArrayList;
import java.util.List;

import org.springframework.jdbc.core.simple.JdbcClient;
import org.springframework.util.Assert;

import dto.Style;

public class StyleRepository {
	
	private final JdbcClient jdbcClient;
	
	public StyleRepository(JdbcClient jdbcClient) {
		this.jdbcClient = jdbcClient;
	}
	
	public ArrayList<Style> findAllById(Integer id) {
		return (ArrayList<Style>) this.jdbcClient
				.sql("SELECT * FROM Styles WHERE clubId = :clubId")
				.param("clubId", id)
				.query(Style.class)
				.list();
	} 
	
	public void create(Style style) {
		int created = this.jdbcClient.sql("INSERT INTO Styles(id, clubId, Name) "
				+ "VALUES(?, ?, ?)")
				.params(List.of(style.getId(), style.getClubId(), style.getName()))
				.update();
		
		Assert.state(created == 1 ? true : false, "Failed to create this style");
	}
	
	public void delete(Integer id) {
		int deleted = this.jdbcClient.sql("DELETE FROM Styles WHERE id = :id")
				.param("id", id)
				.update();
		
		Assert.state(deleted == 1 ? true : false, "Failed to delete this style");
	}
}
