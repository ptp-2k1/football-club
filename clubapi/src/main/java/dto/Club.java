package dto;

import java.util.Objects;

import jakarta.validation.constraints.NotEmpty;

public class Club {
	private int id;
	@NotEmpty
	private String name;
	@NotEmpty
	private String league;
	@NotEmpty
	private String tournament;
	
	public Club() {
		super();
	}

	public Club(int id, String name, String league, String tournament) {
		super();
		this.id = id;
		this.name = name;
		this.league = league;
		this.tournament = tournament;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	public String getLeague() {
		return league;
	}

	public void setLeague(String league) {
		this.league = league;
	}

	public String getTournament() {
		return tournament;
	}

	public void setTournament(String tournament) {
		this.tournament = tournament;
	}

	@Override
	public String toString() {
		return "Club [id=" + id + ", name=" + name + ", league=" + league + ", tournament=" + tournament + "]";
	}

	@Override
	public int hashCode() {
		return Objects.hash(id, league, name, tournament);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Club other = (Club) obj;
		return id == other.id && Objects.equals(league, other.league) && Objects.equals(name, other.name)
				&& Objects.equals(tournament, other.tournament);
	}
}
