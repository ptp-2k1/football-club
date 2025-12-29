package dto;

import java.util.Objects;

import jakarta.validation.constraints.NotEmpty;

public class Style {
	
	private int id;
	private int clubId;
	@NotEmpty
	private String name;
	
	public Style() {
		super();
	}

	public Style(int id, int clubId, String name) {
		super();
		this.id = id;
		this.clubId = clubId;
		this.name = name;
	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
	}

	public int getClubId() {
		return clubId;
	}

	public void setClubId(int clubId) {
		this.clubId = clubId;
	}

	public String getName() {
		return name;
	}

	public void setName(String name) {
		this.name = name;
	}

	@Override
	public String toString() {
		return "Style [id=" + id + ", clubId=" + clubId + ", name=" + name + "]";
	}

	@Override
	public int hashCode() {
		return Objects.hash(clubId, id, name);
	}

	@Override
	public boolean equals(Object obj) {
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Style other = (Style) obj;
		return clubId == other.clubId && id == other.id && Objects.equals(name, other.name);
	}
}
