package controller;

import java.util.ArrayList;

import org.springframework.http.HttpStatus;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.ResponseStatus;
import org.springframework.web.bind.annotation.RestController;

import dto.Match;
import jakarta.validation.Valid;
import repository.MatchRepository;

@RestController
@RequestMapping("api/match")
public class MatchController {
	private final MatchRepository matchRepository;
	
	public MatchController(MatchRepository matchRepository) {
		this.matchRepository = matchRepository;
	}
	
	@GetMapping("")
	public ArrayList<Match> findAll() {
		return this.matchRepository.findAll();
	}
	
	@ResponseStatus(HttpStatus.CREATED)
	@PostMapping("")
	public void create(@Valid @RequestBody Match match) {
		this.matchRepository.create(match);
	}
	
	@ResponseStatus(HttpStatus.NO_CONTENT)
	@DeleteMapping("/{id}")
	public void delete(@PathVariable Integer id) {
		this.matchRepository.delete(id);
	}
}
