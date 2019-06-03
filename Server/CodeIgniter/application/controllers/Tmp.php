<?php
#http://localhost/Server/CodeIgniter/index.php/Tanks/index
class Tmp extends My_Controller{
  public function __construct(){
    parent::__construct();
  }
	public function index()
	{
    parent::index();
  }
  public function Users(){
    $users = $this->Tmp_model->get();
    $this->load->library('table');

    $this->table->set_heading('ID', 'Name', 'Level');
    $template = array( 'table_open' => '<table border="1" cellpadding="2" cellspacing="1" class="mytable">');

    $this->table->set_template($template);
    $data['userstable'] = $this->table->generate($users);

    $this->load->view('templates/header', $data);
    $this->load->view('tanks/Tmp/Users', $data);
    $this->load->view('templates/footer');
  }
  public function Replace(){
    
    $this->load->helper('form');
    $this->load->library('form_validation');

    $this->form_validation->set_rules('id','ID','required');
    $this->form_validation->set_rules('name','Name','required');
    $this->form_validation->set_rules('level','Level','required');

    if ($this->form_validation->run() === FALSE)
    {
      $data['title'] = 'Replace Failed';
      $data['replaced'] = null;
      $this->load->view('templates/header', $data);
      $this->load->view('tanks/Tmp/Replace', $data);
      $this->load->view('templates/footer');
    }
    else{
      $data['title'] = 'Replace Success';
      $data['replaced'] = $this->Tmp_model->replace_data();
      $this->load->view('templates/header', $data);
      $this->load->view('tanks/Tmp/Replace', $data);
      $this->load->view('templates/footer');
    }


  }
  
}
