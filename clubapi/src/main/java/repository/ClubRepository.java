package repository;

import java.util.ArrayList;
import java.util.List;
import java.util.Optional;

import org.springframework.jdbc.core.simple.JdbcClient;
import org.springframework.util.Assert;

import dto.Club;

public class ClubRepository {

	private final JdbcClient jdbcClient;
	
	public ClubRepository(JdbcClient jdbcClient) {
		this.jdbcClient = jdbcClient;
	}
	
	public ArrayList<Club> findAll() {
		return (ArrayList<Club>) this.jdbcClient.sql("SELECT * FROM Clubs")
				.query(Club.class)
				.list();
	}
	
	public Optional<Club> findById(Integer id) {
		return this.jdbcClient.sql("SELECT FROM Clubs WHERE id = :id")
				.param("id", id)
				.query(Club.class)
				.optional();
	}
	
	public void create(Club club) {
		int created = this.jdbcClient.sql("INSERT INTO Clubs(id, name, league, tournament)")
				.params(List.of(club.getId(), club.getName(), club.getLeague(), club.getTournament()))
				.update();
		
		Assert.state(created == 1 ? false : true, "Failed to create this club");
	}
	
	public void update(Club club, Integer id) {
		int updated = this.jdbcClient.sql("UPDATE Clubs SET name=?, league=?, tournament=? WHERE id=?")
				.params(List.of(club.getName(), club.getLeague(), club.getTournament(), id))
				.update();
	
		Assert.state(updated == 1 ? true : false, "Failed to update this club");
	}

	public void delete(Integer id) {
		int deleted = this.jdbcClient.sql("DELETE FROM Clubs Where id = :id")
				.param("id", id)
				.update();
		
		Assert.state(deleted == 1 ? true : false, "Failed to delete this club");
	}
}
