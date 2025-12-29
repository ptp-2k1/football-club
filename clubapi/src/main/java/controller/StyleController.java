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

import dto.Style;
import jakarta.validation.Valid;
import repository.StyleRepository;

@RestController
@RequestMapping("api/style")
public class StyleController {
	
	private final StyleRepository styleRepository;
	
	public StyleController(StyleRepository styleRepository) {
		this.styleRepository = styleRepository;
	}
	
	@GetMapping("/{id}")
	public ArrayList<Style> findAllByClubId(@PathVariable Integer id) {
		return this.styleRepository.findAllById(id);
	}
	
	@ResponseStatus(HttpStatus.CREATED)
	@PostMapping("")
	public void create(@Valid @RequestBody Style style) {
		this.styleRepository.create(style);
	}
	
	@ResponseStatus(HttpStatus.NO_CONTENT)
	@DeleteMapping("{id}")
	public void delete(@PathVariable Integer id) {
		this.styleRepository.delete(id);
	}
}
