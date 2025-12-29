package repository;

import java.util.ArrayList;
import java.util.List;

import org.springframework.jdbc.core.simple.JdbcClient;
import org.springframework.util.Assert;

import dto.Match;

public class MatchRepository {

	private final JdbcClient jdbcClient;

	public MatchRepository(JdbcClient jdbcClient) {
		this.jdbcClient = jdbcClient;
	}
	
	public ArrayList<Match> findAll() {
		return (ArrayList<Match>) this.jdbcClient.sql("SELECT * FROM Matches")
				.query(Match.class)
				.list();
	}
	
	public void create(Match match) {
		int created = this.jdbcClient
				.sql("INSERT INTO Matches(id, firstClub, secondClub, firstScore, secondScore) "
						+ "VALUES(?, ?, ?, ?, ?)")
				.params(List.of(match.getId(), match.getFirstClubId(), match.getSecondClubId(), match.getFirstScore(), match.getSecondScore()))
				.update();
		
		Assert.state(created == 1 ? true : false, "Failed to create this match");
	}
	
	public void delete(Integer id) {
		int deleted = this.jdbcClient.sql("DELETE FROM Matches where id = :id")
				.param("id", id)
				.update();

		Assert.state(deleted == 1 ? true : false, "Failed to delete this match");
	}
}
