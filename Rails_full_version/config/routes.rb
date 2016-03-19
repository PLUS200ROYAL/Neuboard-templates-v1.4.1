Rails.application.routes.draw do

  get 'dashboard/index'

  # defaults to dashboard
  root :to => redirect('/dashboard')
  
  # view routes
  get '/dashboard' => 'dashboard#index'

  get 'ui/buttons'
  get 'ui/sliders_progress'
  get 'ui/blank_page'
  get 'ui/modals_popups'
  get 'ui/tabs_accordions'
  get 'ui/alerts_notifications'
  get 'ui/nestable_lists'
  get 'ui/panels'
  get 'ui/icons'
  get 'ui/typography'

  get 'forms/components'
  get 'forms/validation'
  get 'forms/mask'
  get 'forms/wizard'
  get 'forms/multiple_file'
  get 'forms/wysiwyg'

  get 'tables/basic_tables'
  get 'tables/data_tables'

  get 'charts/chartjs'
  get 'charts/c3'
  get 'charts/morris'
  get 'charts/sparkline'

  get 'mail/inbox'
  get 'mail/compose'

  get 'maps/google'
  get 'maps/vector'

  get 'pages/blank_page'
  get 'pages/profile'
  get 'pages/signon'
  get 'pages/signup'
  get 'pages/locked_screen'
  get 'pages/page404'
  get 'pages/page500'

  get '/animations' => 'animations#index'




end
