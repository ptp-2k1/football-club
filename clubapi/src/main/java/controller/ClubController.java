package controller;

import java.util.ArrayList;
import java.util.Optional;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import dto.Club;
import jakarta.validation.Valid;
import repository.ClubRepository;

@RestController
@RequestMapping("api/club")
public class ClubController {
	private final ClubRepository clubRepository;
	
	public ClubController(ClubRepository clubRepository) {
		this.clubRepository = clubRepository;
	}
	
	@GetMapping("")
	public ArrayList<Club> findAll() {
		return this.clubRepository.findAll();
	}
	
	@GetMapping("{id}")
	public Club findById(@PathVariable Integer id) {
		Optional<Club> club = this.clubRepository.findById(id);
//		if(club.isEmpty()) return ClubNotFoundException;
		return club.get();
	}
	
	@ResponseStatus(HttpStatus.CREATED)
	@PostMapping("")
	public void create(@Valid @RequestBody Club club) {
		this.clubRepository.create(club);
	}
	
	@ResponseStatus(HttpStatus.NO_CONTENT)
	@PutMapping("{id}")
	public void update(@Valid @RequestBody Club club, @PathVariable Integer id) {
		this.clubRepository.update(club, id);
	}
	
	@ResponseStatus(HttpStatus.NO_CONTENT)
	@DeleteMapping("{id}")
	public void delete(@PathVariable Integer id) {
		this.clubRepository.delete(id);
	}
}
