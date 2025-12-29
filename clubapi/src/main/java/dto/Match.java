package dto;

import java.util.Objects;

public class Match {
	private int id;
	private int firstClubId;
	private int secondClubId;
	private int firstScore;
	private int secondScore;
	
	public Match() {
		super();
	}

	public Match(int id, int firstClubId, int secondClubId, int firstScore, int secondScore) {
		super();
		this.id = id;
		this.firstClubId = firstClubId;
		this.secondClubId = secondClubId;
		this.firstScore = firstScore;
		this.secondScore = secondScore;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getFirstClubId() {
		return firstClubId;
	}

	public void setFirstClubId(int firstClubId) {
		this.firstClubId = firstClubId;
	}

	public int getSecondClubId() {
		return secondClubId;
	}

	public void setSecondClubId(int secondClubId) {
		this.secondClubId = secondClubId;
	}

	public int getFirstScore() {
		return firstScore;
	}

	public void setFirstScore(int firstScore) {
		this.firstScore = firstScore;
	}

	public int getSecondScore() {
		return secondScore;
	}

	public void setSecondScore(int secondScore) {
		this.secondScore = secondScore;
	}

	@Override
	public String toString() {
		return "Match [id=" + id + ", firstClubId=" + firstClubId + ", secondClubId=" + secondClubId + ", firstScore="
				+ firstScore + ", secondScore=" + secondScore + "]";
	}

	@Override
	public int hashCode() {
		return Objects.hash(firstClubId, firstScore, id, secondClubId, secondScore);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Match other = (Match) obj;
		return firstClubId == other.firstClubId && firstScore == other.firstScore && id == other.id
				&& secondClubId == other.secondClubId && secondScore == other.secondScore;
	}
}
